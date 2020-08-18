using System;
using System.Collections.Generic;
using Resital.Core.Services;
using Resital.DTO;

namespace Resital.BLL.Abstract
{
    public interface IRoomTypeService : IServiceBase
    {
        List<RoomTypeDto> getAllRoomTypes();

        RoomTypeDto getRoomType(Guid roomTypeId);

        List<RoomTypeDto> getRoomTypeName(string roomTypeName);

        RoomTypeDto addRoomType(RoomTypeDto roomType);

        RoomTypeDto updateRoomType(RoomTypeDto roomType);

        bool deleteRoomType(Guid roomTypeId);
    }
}