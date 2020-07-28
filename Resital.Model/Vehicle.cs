using Resital.Core.Entities;
using System;

namespace Resital.Model
{
    public class Vehicle : Entity<Guid>
    {
        public string Name { get; set; }

        public Company Company { get; set; }
        public VehicleType VehicleType { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}