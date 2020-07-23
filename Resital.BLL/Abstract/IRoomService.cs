using Resital.Core.Services;
using Resital.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Resital.BLL.Abstract
{
    public interface IRoomService : IServiceBase
    {
        List<RoomDTO> getAllRooms();
        RoomDTO getRoom(int roomId);
        RoomDTO addRoom(RoomDTO room);
        RoomDTO updateRoomType(RoomDTO room);
        bool deleteRoom(int roomId);
    }
}
