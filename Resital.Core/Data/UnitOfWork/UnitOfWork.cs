using Microsoft.EntityFrameworkCore;
using Resital.Core.Data.Repositories;
using Resital.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Resital.Core.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext context;
        private readonly Dictionary<Type, object> Repos;
        private bool disposed = false;

        public UnitOfWork(DbContext _context)
        {
            context = _context;
            Repos ??= new Dictionary<Type, object>();
        }

        public void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public IRepository<T> GetRepository<T>() where T : Entity<int>
        {
            if (Repos.Keys.Contains(typeof(T)))
            {
                return Repos[typeof(T)] as IRepository<T>;
            }
            var repository = new RepositoryBase<T>(context);
            Repos.Add(typeof(T), repository);
            return repository;
        }

        public int SaveChanges()
        {
            return context.SaveChanges();
        }
    }
}
