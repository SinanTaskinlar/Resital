using System;
using Resital.Model;

namespace Resital.DTO
{
    public class CompanyRouteDto
    {
        public Guid Id { get; set; }
        public Company Company { get; set; }
        public Route Route { get; set; }
    }
}