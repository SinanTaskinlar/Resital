using Resital.Core.Entities;
using System;

namespace Resital.Model
{
    public class Route : Entity<Guid>
    {
        public string Name { get; set; }
        public Company Company { get; set; }
        public City StartLocation { get; set; }
        public City EndLocation { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}