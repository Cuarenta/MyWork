using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using Admin.Compoent.Tool;

namespace Admin.Component.Data
{
    /// <summary>
    ///     数据单元操作接口
    /// </summary>
    public interface IUnitOfWorkContext : IUnitOfWork, IDisposable
    {
        /// <summary>
        /// 注册一个新的对象到上下文仓储
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="entity"></param>
        void RegisterNew<TEntity, TKey>(TEntity entity) where TEntity : EntityBase<TKey>;
        /// <summary>
        /// 批量注册多个新的对象到上下文仓储
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="entity"></param>
        void RegisterNew<TEntity, TKey>(IQueryable<TEntity> entity) where TEntity : EntityBase<TKey>;

        void RegistreModified<TEntity, TKey>(TEntity entity) where TEntity : EntityBase<TKey>;
        void RegistreDelete<TEntity, TKey>(TEntity entity) where TEntity : EntityBase<TKey>;

        void RegistreDelete<TEntity, TKey>(IQueryable<TEntity> entity) where TEntity : EntityBase<TKey>;

        void RegistreDeleteA<TEntity, TKey>(IQueryable<TEntity> entity) where TEntity : EntityBase<TKey>;



    }
}