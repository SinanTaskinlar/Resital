using Resital.Core.Services;
using Resital.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Resital.BLL.Abstract
{
    public interface IRoomLocationService : IServiceBase
    {
        List<RoomLocationDTO> getAllRoomLocations();
        RoomLocationDTO getRoomLocation(int roomLocationId);
        List<RoomLocationDTO> getRoomLocationName(string roomLocationName);
        RoomLocationDTO addRoomLocation(RoomLocationDTO roomLocation);
        RoomLocationDTO updateRoomLocation(RoomLocationDTO roomLocation);
        bool deleteRoomLocation(int roomLocationId);
    }
}
