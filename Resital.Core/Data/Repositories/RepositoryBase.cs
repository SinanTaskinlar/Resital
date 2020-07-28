using Microsoft.EntityFrameworkCore;
using Resital.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Resital.Core.Data.Repositories
{
    public class RepositoryBase<T> : IRepository<T> where T : Entity<Guid>
    {
        private readonly DbContext _context;
        private readonly DbSet<T> _entities;

        public RepositoryBase(DbContext context)
        {
            this._context = context;
            this._entities = this._context.Set<T>();
        }

        public T GetById(Guid id)
        {
            return _entities.SingleOrDefault(s => s.Id == id);
        }

        public void Insert(T entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));

            _entities.Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            _context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            if (id == default) throw new ArgumentNullException("entity");
            {
                T entity = _entities.SingleOrDefault(s => s.Id == id);
                _entities.Remove(entity);
                _context.SaveChanges();
            }
        }

        public T GetById(Expression<Func<T, bool>> filter = null)
        {
            return null;
        }

        public T GetById(Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] includes)
        {
            return null;
        }

        public IQueryable<T> GetById(params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = _context.Set<T>();
            foreach (var include in includes) query = query.Include(include.Name);
            return query;
        }

        public IQueryable<T> GetById(Expression<Func<T, bool>> filter = null, Expression<Func<T, object>> include = null)
        {
            return GetQueryable(filter, include, null);
        }

        public IQueryable<T> GetById(Expression<Func<T, bool>> filter = null, Expression<Func<T, object>> include = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, int? skip = null,
            int? take = null)
        {
            return null;
        }

        public IEnumerable<T> GetAll()
        {
            return _entities.AsEnumerable();
        }

        protected virtual IQueryable<T> GetQueryable(
            Expression<Func<T, bool>> filter = null,
            Expression<Func<T, object>> include = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            int? skip = null,
            int? take = null)
        {
            IQueryable<T> query = _context.Set<T>();
            if (filter != null)
            {
                query = query.Where(filter);
            }
            if (include != null)
            {
                query = query.Include(include);
            }
            if (orderBy != null)
            {
                query = orderBy(query);
            }
            if (skip.HasValue)
            {
                query = query.Skip(skip.Value);
            }
            if (take.HasValue)
            {
                query = query.Take(take.Value);
            }

            return query;
        }
    }
}