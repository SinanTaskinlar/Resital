using Resital.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Resital.Model
{
    public class CompanyRoute : Entity<int>
    {
        public Company Company { get; set; }
        public Route Route { get; set; }
    }
}
