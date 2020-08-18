using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Resital.Core.Entities;

namespace Resital.Core.Data.Repositories
{
    public interface IRepository<T> where T : Entity<Guid>
    {
        IEnumerable<T> GetAll();

        T GetById(Guid id);

        void Insert(T entity);

        void Update(T entity);

        void Delete(Guid id);

        T GetById(Expression<Func<T, bool>> filter = null);
        IQueryable<T> GetById(params Expression<Func<T, object>>[] includes);

        IQueryable<T> GetById(Expression<Func<T, bool>> filter = null,
            Expression<Func<T, object>> include = null);

        IQueryable<T> GetById(Expression<Func<T, bool>> filter = null,
            Expression<Func<T, object>> include = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            int? skip = null,
            int? take = null
        );
    }
}