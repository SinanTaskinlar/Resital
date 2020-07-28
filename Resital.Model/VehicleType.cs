using Resital.Core.Entities;
using System;
using System.Collections.Generic;

namespace Resital.Model
{
    public class VehicleType : Entity<Guid>
    {
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public ICollection<Vehicle> Vehicles { get; set; }
    }
}