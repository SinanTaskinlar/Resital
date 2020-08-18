using System;
using System.Collections.Generic;
using Resital.Core.Entities;

namespace Model
{
    public class Cart : Entity<Guid>
    {
        public Guid UserId { get; set; }
        public List<CartItem> CartItems { get; set; }
    }
}