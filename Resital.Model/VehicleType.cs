using System;
using System.Collections.Generic;
using Resital.Core.Entities;

namespace Resital.Model
{
    public class VehicleType : Entity<Guid>
    {
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public ICollection<Vehicle> Vehicles { get; set; }
    }
}