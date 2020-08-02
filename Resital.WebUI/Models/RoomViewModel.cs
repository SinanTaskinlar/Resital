using Resital.DTO;
using System.Collections.Generic;

namespace Resital.WebUI.Models
{
    public class RoomViewModel
    {
        public List<CompanyDto> Companies { get; set; }
        public List<RoomLocationDto> Locations { get; set; }
        public List<RoomTypeDto> Types { get; set; }
    }
}