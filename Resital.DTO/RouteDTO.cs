using Resital.Model;
using System;

namespace Resital.DTO
{
    public class RouteDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public City StartLocation { get; set; }
        public City EndLocation { get; set; }
    }
}