using Resital.Model;
using System;

namespace Resital.DTO
{
    public class CompanyRouteDTO
    {
        public Guid Id { get; set; }
        public Company Company { get; set; }
        public Route Route { get; set; }
    }
}