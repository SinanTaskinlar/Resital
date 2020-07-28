using Resital.Model;
using System;

namespace Resital.DTO
{
    public class VehicleDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public VehicleType VehicleType { get; set; }
    }
}