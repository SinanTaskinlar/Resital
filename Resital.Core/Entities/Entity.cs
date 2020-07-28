using System;

namespace Resital.Core.Entities
{
    public abstract class Entity<T> : EntityBase, IEntity<T>
    {
        public Guid Id { get; set; }
    }
}