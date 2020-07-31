using Resital.Core.Services;
using Resital.DTO;
using System;
using System.Collections.Generic;

namespace Resital.BLL.Abstract
{
    public interface IRoomService : IServiceBase
    {
        List<RoomDto> getAllRooms();

        RoomDto getRoom(Guid roomId);

        RoomDto addRoom(RoomDto room);

        RoomDto updateRoom(RoomDto room);

        bool deleteRoom(Guid roomId);
    }
}