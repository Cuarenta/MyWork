using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using Admin.Compoent.Tool;
using Admin.Compoent.Tool.Extend;
using Admin.Demo.Site;
using Admin.Demo.Site.Impl;
using Admin.Demo.Site.Models;

namespace Admin.Controllers
{
    [Export]
    public class HomeController : Controller
    {
        public HomeController()
        {
            //AccountContract = new AccountSiteService();
        }

        #region 属性
        [Import]
        public IAccountSiteContract AccountContract { get; set; }

        #endregion
        // GET: Home
        public ActionResult Login()
        {
            string returnUrl = Request.Params["returnUrl"];
            returnUrl = returnUrl ?? Url.Action("Login", "Home", new { area = "" });
            var model = new LoginModel
            {
                ReturnUrl = returnUrl
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            try
            {
                OperationResult result = AccountContract.Login(model);
                
                var msg = result.Message ?? result.ResultType.ToDescription();
                if (result.ResultType == OperationResultType.Success)
                {
                    return Redirect(model.ReturnUrl);
                }
                ModelState.AddModelError("", msg);
                return View(model);
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
                return View(model);
            }
        }
       
    }
}