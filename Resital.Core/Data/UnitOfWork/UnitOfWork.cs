using Microsoft.EntityFrameworkCore;
using Resital.Core.Data.Repositories;
using Resital.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Resital.Core.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;
        private readonly Dictionary<Type, object> _repos;
        private bool _disposed = false;

        public UnitOfWork(DbContext context)
        {
            this._context = context;
            _repos ??= new Dictionary<Type, object>();
        }

        private void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public IRepository<T> GetRepository<T>() where T : Entity<Guid>
        {
            if (_repos.Keys.Contains(typeof(T)))
            {
                return _repos[typeof(T)] as IRepository<T>;
            }
            var repository = new RepositoryBase<T>(_context);
            _repos.Add(typeof(T), repository);
            return repository;
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}