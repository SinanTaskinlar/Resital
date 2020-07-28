using System;

namespace Resital.Core.Entities
{
    public interface IEntity<T>
    {
        public Guid Id { get; set; }
    }
}