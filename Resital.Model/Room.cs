using Resital.Core.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Resital.Model
{
    public class Room : Entity<Guid>
    {
        public Company Company { get; set; }
        public RoomLocation RoomLocation { get; set; }
        public RoomType RoomType { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}