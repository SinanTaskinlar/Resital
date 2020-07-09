using Resital.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Resital.Model
{
    public class Route : Entity<Guid>
    {
        public string Name { get; set; }
        public City StartLocation { get; set; }
        public City EndLocation { get; set; }
    }
}
