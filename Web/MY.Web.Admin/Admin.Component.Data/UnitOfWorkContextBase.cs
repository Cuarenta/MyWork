using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.Component.Data
{

    /// <summary>
    ///     单元操作实现
    /// </summary>
    public abstract class UnitOfWorkContextBase : IUnitOfWorkContext
    {
        

        public void RegisterNew<TEntity, TKey>(TEntity entity) where TEntity : Compoent.Tool.EntityBase<TKey>
        {
            throw new NotImplementedException();
        }

        public void RegisterNew<TEntity, TKey>(IQueryable<TEntity> entity) where TEntity : Compoent.Tool.EntityBase<TKey>
        {
            throw new NotImplementedException();
        }

        public void RegistreModified<TEntity, TKey>(TEntity entity) where TEntity : Compoent.Tool.EntityBase<TKey>
        {
            throw new NotImplementedException();
        }

        public void RegistreDelete<TEntity, TKey>(TEntity entity) where TEntity : Compoent.Tool.EntityBase<TKey>
        {
            throw new NotImplementedException();
        }

        public void RegistreDelete<TEntity, TKey>(IQueryable<TEntity> entity) where TEntity : Compoent.Tool.EntityBase<TKey>
        {
            throw new NotImplementedException();
        }

        public bool IsCommitted
        {
            get { throw new NotImplementedException(); }
        }

        public int Commit(bool validateOnSaveEnabled = true)
        {
            throw new NotImplementedException();
        }

        public void Rollback()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }


        public void RegistreDeleteA<TEntity, TKey>(IQueryable<TEntity> entity) where TEntity : Compoent.Tool.EntityBase<TKey>
        {
            throw new NotImplementedException();
        }
        public void RegistreDeleteB<TEntity, TKey>(IQueryable<TEntity> entity) where TEntity : Compoent.Tool.EntityBase<TKey>
        {
            throw new NotImplementedException();
        }
        public void RegistreDeleteC<TEntity, TKey>(IQueryable<TEntity> entity) where TEntity : Compoent.Tool.EntityBase<TKey>
        {
            throw new NotImplementedException();
        }
    }
}

