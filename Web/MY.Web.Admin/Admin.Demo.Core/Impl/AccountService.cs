﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Admin.Compoent.Tool;
using Admin.Demo.Core.Models.Account;

namespace Admin.Demo.Core.Impl
{
    public abstract class AccountService:IAccountContract
    {
        private static readonly  Member[] Members=new Member[]
        {
            new Member(){UserName = "Admin",Email = "258065584@qq.com",NickName = "BBking",Password = "123456"},
            new Member(){UserName = "agent",Email = "258065584@qq.com",NickName = "Zking",Password = "123456"}
        };
        private static readonly List<LoginLog> LoginLogs = new List<LoginLog>();
        public Compoent.Tool.OperationResult Login(LoginInfo loginInfo)
        {
            if (loginInfo != null)
            {
                var member =
                    Members.SingleOrDefault(m => m.UserName == loginInfo.Account || m.Email == loginInfo.Account);
                if (member == null)
                {
                    return new OperationResult(OperationResultType.QueryNull, "指定账号的用户不存在。");
                }
                if (member.Password != loginInfo.Password)
                {
                    return new OperationResult(OperationResultType.Success, "登陆密码不正确。");
                }
                var loginLog = new LoginLog {IpAddress = loginInfo.IpAddress, Member = member};
                LoginLogs.Add(loginLog);
                return new OperationResult(OperationResultType.Success, "登录成功。", member);
            }
            return null;

        }
    }
}