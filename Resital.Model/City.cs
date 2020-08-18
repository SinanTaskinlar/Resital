using System;
using Resital.Core.Entities;

namespace Resital.Model
{
    public class City : Entity<Guid>
    {
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}