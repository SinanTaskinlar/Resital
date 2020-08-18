using System;
using Resital.Model;

namespace Resital.DTO
{
    public class VehicleDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public VehicleType VehicleType { get; set; }
    }
}