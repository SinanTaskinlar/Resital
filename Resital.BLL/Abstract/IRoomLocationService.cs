using System;
using System.Collections.Generic;
using Resital.Core.Services;
using Resital.DTO;

namespace Resital.BLL.Abstract
{
    public interface IRoomLocationService : IServiceBase
    {
        List<RoomLocationDto> getAllRoomLocations();

        RoomLocationDto getRoomLocation(Guid roomLocationId);

        RoomLocationDto addRoomLocation(RoomLocationDto roomLocation);

        RoomLocationDto updateRoomLocation(RoomLocationDto roomLocation);

        bool deleteRoomLocation(Guid roomLocationId);
    }
}