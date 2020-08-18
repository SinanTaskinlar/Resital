using System.Collections.Generic;
using Resital.DTO;

namespace Resital.WebUI.Models
{
    public class RoomViewModel
    {
        public List<CompanyDto> Companies { get; set; }
        public List<RoomLocationDto> Locations { get; set; }
        public List<RoomTypeDto> Types { get; set; }
    }
}