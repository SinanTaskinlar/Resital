using Resital.Model;
using System;

namespace Resital.DTO
{
    public class RoomDto
    {
        public Guid Id { get; set; }
        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
        public Guid RoomLocationId { get; set; }
        public RoomLocation RoomLocation { get; set; }
        public Guid RoomTypeId { get; set; }
        public RoomType RoomType { get; set; }
    }
}