using Resital.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Resital.Model
{
    public class City : Entity<int>
    {
        public string Name { get; set; }
    }
}
