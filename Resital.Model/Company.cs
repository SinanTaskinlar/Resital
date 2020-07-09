using Resital.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Resital.Model
{
    public class Company : Entity<Guid>
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Note { get; set; }
        public int CompnayTypeId { get; set; }
        public virtual CompanyType CompanyType { get; set; }
        public virtual ICollection<Room> Rooms { get; set; }
        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
