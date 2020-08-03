using System;
using System.Collections.Generic;
using System.Text;
using Resital.Core.Entities;
using Resital.Model;

namespace Model
{
    public class CartItem : Entity<Guid>
    {
        public Guid CardId { get; set; }
        public Cart Cart { get; set; }
        public Guid RoomId { get; set; }
        public Room Room { get; set; }
        public int Quantity { get; set; }

    }
}
