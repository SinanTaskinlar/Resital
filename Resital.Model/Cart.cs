using System;
using System.Collections.Generic;
using System.Text;
using Resital.Core.Entities;

namespace Model
{
    public class Cart : Entity<Guid>
    {
        public string UserId { get; set; }
        public List<CartItem> CartItems { get; set; }
    }
}
