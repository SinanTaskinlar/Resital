using System;
using System.Collections.Generic;
using System.Text;
using Resital.Model;

namespace Model
{
    public class OrderItem
    {
        public Guid Id { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int RoomId { get; set; }
        public Room Room { get; set; }
    }
}
