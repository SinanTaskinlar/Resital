using System;
using System.Collections.Generic;
using Resital.Core.Entities;

namespace Resital.Model
{
    public class Company : Entity<Guid>
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Note { get; set; }
        public Guid CompanyTypeId { get; set; }
        public CompanyType CompanyType { get; set; }
        public ICollection<Room> Rooms { get; set; }
        public ICollection<Vehicle> Vehicles { get; set; }
        public ICollection<Route> Routes { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}