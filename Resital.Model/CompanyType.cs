using Resital.Core.Entities;
using System;
using System.Collections.Generic;

namespace Resital.Model
{
    public class CompanyType : Entity<Guid>
    {
        public string TypeName { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public ICollection<Company> Companies { get; set; }
    }
}