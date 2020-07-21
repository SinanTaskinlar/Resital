using Resital.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Resital.Model
{
    public class CompanyType : Entity<int>
    {
        public string TypeName { get; set; }
    }
}
