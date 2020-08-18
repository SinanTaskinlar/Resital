using System;
using System.Collections.Generic;
using Resital.Core.Entities;

namespace Resital.Model
{
    public class RoomType : Entity<Guid>
    {
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public ICollection<Room> Rooms { get; set; }
    }
}