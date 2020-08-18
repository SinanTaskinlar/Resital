using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Resital.BLL.Abstract;
using Resital.Core.Data.UnitOfWork;
using Resital.DTO;
using Resital.Model;

namespace Resital.BLL.Services
{
    public class RoomTypeService : IRoomTypeService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public RoomTypeService(IUnitOfWork uow, IMapper mapper)
        {
            _mapper = mapper;
            _uow = uow;
        }

        public List<RoomTypeDto> getAllRoomTypes()
        {
            var room = _uow.GetRepository<RoomType>().GetAll().ToList();
            return _mapper.Map<List<RoomTypeDto>>(room);
        }

        public RoomTypeDto getRoomType(Guid roomTypeId)
        {
            var type = _uow.GetRepository<RoomType>().GetById(z => z.Id == roomTypeId);
            return _mapper.Map<RoomTypeDto>(type);
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

        public bool deleteRoomType(Guid roomTypeId)
        {
            throw new NotImplementedException();
        }
    }
}