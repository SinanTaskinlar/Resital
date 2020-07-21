using Resital.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resital.DTO
{
    public class CompanyDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Note { get; set; }
        public int CompanyTypeId { get; set; }
        public List<Room> Rooms { get; set; }
        public List<Vehicle> Vehicles { get; set; }
    }
}
