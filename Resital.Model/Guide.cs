using Resital.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Resital.Model
{
    public class Guide : Entity<Guid>
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Language { get; set; }
    }
}
