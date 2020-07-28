﻿using Resital.Model;
using System;

namespace Resital.DTO
{
    public class RoomDTO
    {
        public Guid Id { get; set; }
        public Company Company { get; set; }
        public RoomLocation RoomLocation { get; set; }
        public RoomType RoomType { get; set; }
    }
}