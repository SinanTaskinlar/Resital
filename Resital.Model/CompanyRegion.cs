using Resital.Core.Entities;
using System;

namespace Resital.Model
{
    public class CompanyRegion : Entity<Guid>
    {
        public Company Company { get; set; }
        public Region Region { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}