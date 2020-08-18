using System;
using Resital.Core.Data.Repositories;
using Resital.Core.Entities;

namespace Resital.Core.Data.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<T> GetRepository<T>() where T : Entity<Guid>;

        int SaveChanges();
    }
}