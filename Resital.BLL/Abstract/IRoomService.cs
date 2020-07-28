using Resital.Core.Services;
using Resital.DTO;
using System;
using System.Collections.Generic;

namespace Resital.BLL.Abstract
{
    public interface IRoomService : IServiceBase
    {
        List<RoomDTO> getAllRooms();

        RoomDTO getRoom(Guid roomId);

        RoomDTO addRoom(RoomDTO room);

        RoomDTO updateRoom(RoomDTO room);

        bool deleteRoom(Guid roomId);
    }
}