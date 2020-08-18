using System;
using Resital.Core.Entities;

namespace Resital.Model
{
    public class Guide : Entity<Guid>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string Language { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}