using Resital.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Resital.Model
{
    public class Company : Entity<int>
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Note { get; set; }
        public int CompanyTypeId { get; set; }
        public virtual CompanyType CompanyType { get; set; }
        public virtual ICollection<Room> Rooms { get; set; }
        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
