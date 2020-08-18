using System;
using System.Collections.Generic;
using Resital.Model;

namespace Resital.DTO
{
    public class CompanyDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Note { get; set; }
        public Guid CompanyTypeId { get; set; }
        public List<Room> Rooms { get; set; }
        public List<Vehicle> Vehicles { get; set; }
    }
}