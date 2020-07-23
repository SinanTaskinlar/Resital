using Resital.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Resital.Model
{
    public class Room : Entity<int>
    {
        public Company Hotel  { get; set; }
        public RoomLocation RoomLocation { get; set; }
        public RoomType RoomType { get; set; }
    }
}
