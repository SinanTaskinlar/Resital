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
            return _entities.Find(id);
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
            if (id == default) throw new ArgumentNullException(nameof(id));
            {
                T entity = _entities.SingleOrDefault(s => s.Id == id);
                _entities.Remove(entity);
                _context.SaveChanges();
            }
        }

        public T GetById(Expression<Func<T, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public T GetById(Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetById(params Expression<Func<T, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetById(Expression<Func<T, bool>> filter = null, Expression<Func<T, object>> include = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetById(Expression<Func<T, bool>> filter = null, Expression<Func<T, object>> include = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, int? skip = null,
            int? take = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            return _entities.ToList();
        }
    }
}