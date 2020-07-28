using Resital.Core.Services;
using Resital.DTO;
using System;
using System.Collections.Generic;

namespace Resital.BLL.Abstract
{
    public interface IRoomLocationService : IServiceBase
    {
        List<RoomLocationDTO> getAllRoomLocations();

        RoomLocationDTO getRoomLocation(Guid roomLocationId);

        RoomLocationDTO addRoomLocation(RoomLocationDTO roomLocation);

        RoomLocationDTO updateRoomLocation(RoomLocationDTO roomLocation);

        bool deleteRoomLocation(Guid roomLocationId);
    }
}