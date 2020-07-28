using Resital.Core.Entities;
using System;

namespace Resital.Model
{
    public class CompanyRoute : Entity<Guid>
    {
        public Company Company { get; set; }
        public Route Route { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}