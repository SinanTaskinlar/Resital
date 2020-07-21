using Resital.Core.Data.Repositories;
using Resital.Core.Entities;
using System;

namespace Resital.Core.Data.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<T> GetRepository<T>() where T : Entity<int>;
        int SaveChanges();
    }
}
