using Resital.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resital.DTO
{
    public class VehicleDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public VehicleType VehicleType{ get; set; }
    }
}
