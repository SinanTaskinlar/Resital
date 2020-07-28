using Resital.Model;
using System;

namespace Resital.DTO
{
    public class CompanyRegionDTO
    {
        public Guid Id { get; set; }
        public Company Company { get; set; }
        public Region Region { get; set; }
    }
}