using Resital.Core.Entities;
using System;

namespace Resital.Model
{
    public class CompanyType : Entity<Guid>
    {
        public string TypeName { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}