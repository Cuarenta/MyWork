using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Admin.Compoent.Tool;
using Admin.Component.Data.ef;

namespace Admin.Component.Data
{
    public abstract class EfRepositoryBase<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : EntityBase<TKey>
    {
        /// <summary>
        /// 获取 仓储上下文的实例
        /// </summary>
        [Import]
        public IUnitOfWork UnitOfWork { get; set; }

        /// <summary>
        /// 获取或设置 EntityFramework的数据仓储上下文
        /// </summary>
        public IUnitOfWorkContext EfContext
        {
            get
            {
                if (UnitOfWork is IUnitOfWorkContext)
                {
                    return UnitOfWork as IUnitOfWorkContext;
                }
                throw new DataAccessException(string.Format("数据仓储上下文对象类型不正确，应为IUnitOfWorkContext，实际为 {0}", UnitOfWork.GetType().Name));
            }
        }
        /// <summary>
        ///     获取 当前实体的查询数据集
        /// </summary>
        public virtual IQueryable<TEntity> Entities { get; set; }

        public int Insert(TEntity entity, bool isSave = true)
        {
            throw new NotImplementedException();
        }

        public int Insert(IEnumerable<TEntity> entities, bool isSave = true)
        {
            throw new NotImplementedException();
        }

        public int Delete(TKey id, bool isSave = true)
        {
            throw new NotImplementedException();
        }

        public int Delete(TEntity entity, bool isSave = true)
        {
            throw new NotImplementedException();
        }

        public int Delete(IEnumerable<TEntity> entities, bool isSave = true)
        {
            throw new NotImplementedException();
        }

        public int Delete(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate, bool isSave = true)
        {
            throw new NotImplementedException();
        }

        public int Update(TEntity entity, bool isSave = true)
        {
            throw new NotImplementedException();
        }

        public int Update(System.Linq.Expressions.Expression<Func<TEntity, object>> propertyExpression, TEntity entity, bool isSave = true)
        {
            throw new NotImplementedException();
        }

        public TEntity GetByKey(TKey key)
        {
            throw new NotImplementedException();
        }
    }
}
