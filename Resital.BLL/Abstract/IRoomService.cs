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
        List<RoomDTO> getRoomName(string roomName);
        RoomDTO addRoom(RoomDTO room);
        RoomTypeDTO updateRoomType(RoomDTO room);
        bool deleteRoom(int roomId);
    }
}
