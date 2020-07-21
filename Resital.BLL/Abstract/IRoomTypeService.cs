using Resital.Core.Services;
using Resital.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Resital.BLL.Abstract
{
    public interface IRoomTypeService : IServiceBase
    {
        List<RoomTypeDTO> getAllRoomTypes();
        RoomTypeDTO getRoomType(int roomTypeId);
        List<RoomTypeDTO> getRoomTypeName(string roomTypeName);
        RoomTypeDTO addRoomType(RoomTypeDTO roomType);
        RoomTypeDTO updateRoomType(RoomTypeDTO roomType);
        bool deleteRoomType(int roomTypeId);
    }
}
