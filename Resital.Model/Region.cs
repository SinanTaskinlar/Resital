using Resital.Core.Entities;
using System;

namespace Resital.Model
{
    public class Region : Entity<Guid>
    {
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}