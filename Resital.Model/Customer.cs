using System;
using Resital.Core.Entities;

namespace Resital.Model
{
    public class Customer : Entity<Guid>
    {
        public string Username { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}