using System;
using Resital.Core.Entities;

namespace Resital.Model
{
    public class Room : Entity<Guid>
    {
        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
        public Guid RoomLocationId { get; set; }
        public RoomLocation RoomLocation { get; set; }
        public Guid RoomTypeId { get; set; }
        public RoomType RoomType { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}