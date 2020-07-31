using AutoMapper;
using Resital.BLL.Abstract;
using Resital.Core.Data.UnitOfWork;
using Resital.DTO;
using Resital.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Resital.BLL.Services
{
    public class RoomTypeService : IRoomTypeService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public RoomTypeService(IUnitOfWork uow, IMapper mapper)
        {
            this._mapper = mapper;
            this._uow = uow;
        }

        public List<RoomTypeDto> getAllRoomTypes()
        {
            var room = _uow.GetRepository<RoomType>().GetAll().ToList();
            return _mapper.Map<List<RoomTypeDto>>(room);
        }

        public RoomTypeDto getRoomType(int roomTypeId)
        {
            throw new NotImplementedException();
        }

        public List<RoomTypeDto> getRoomTypeName(string roomTypeName)
        {
            throw new NotImplementedException();
        }

        public RoomTypeDto addRoomType(RoomTypeDto roomType)
        {
            throw new NotImplementedException();
        }

        public RoomTypeDto updateRoomType(RoomTypeDto roomType)
        {
            throw new NotImplementedException();
        }

        public bool deleteRoomType(int roomTypeId)
        {
            throw new NotImplementedException();
        }
    }
}