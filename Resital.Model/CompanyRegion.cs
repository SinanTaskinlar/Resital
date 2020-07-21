using Resital.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Resital.Model
{
    public class CompanyRegion : Entity<int>
    {
        public Company Company { get; set; }
        public Region Region { get; set; }
    }
}
