using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Policy.Infrastructure.Interfaces
{
    public interface IRepository<TEntity, TPrimaryKey> where TEntity : class
    {
        TEntity FindById(TPrimaryKey id, params Expression<Func<TEntity, object>>[] includeProperties);

        TEntity FindByIdAsNoTracking(TPrimaryKey id, params Expression<Func<TEntity, object>>[] includeProperties);

        TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties);

        TEntity FindSingle(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties);

        IQueryable<TEntity> FindAll(params Expression<Func<TEntity, object>>[] includeProperties);

        IQueryable<TEntity> FindAllAsNoTracking(params Expression<Func<TEntity, object>>[] includeProperties);

        IQueryable<TEntity> FindAll(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties);

        void Add(TEntity entity);

        void Update(TEntity entity);

        void Remove(TEntity entity);

        void Remove(TPrimaryKey id);

        void RemoveMultiple(List<TEntity> entities);
    }
}