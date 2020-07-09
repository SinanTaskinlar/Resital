using Resital.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Resital.Model
{
    public class Vehicle : Entity<Guid>
    {
        public string Name { get; set; }
        public VehicleType VehicleType { get; set; }
    }
}
