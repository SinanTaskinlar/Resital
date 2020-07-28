using Resital.Core.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Resital.Model
{
    public class Room : Entity<Guid>
    {
        [ForeignKey("Company")]
        public Guid CompanyId { get; set; }

        public Company Company { get; set; }

        [ForeignKey("RoomLocation")]
        public Guid RoomLocationId { get; set; }

        public RoomLocation RoomLocation { get; set; }

        [ForeignKey("RoomType")]
        public Guid RoomTypeId { get; set; }

        public RoomType RoomType { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}