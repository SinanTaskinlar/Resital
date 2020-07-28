using Resital.Core.Entities;
using System;

namespace Resital.Model
{
    public class Employee : Entity<Guid>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }

        //TODO: Mail regex
        public string Mail { get; set; }

        public string Authority { get; set; }

        //TODO: Self Foreign Key authority
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}