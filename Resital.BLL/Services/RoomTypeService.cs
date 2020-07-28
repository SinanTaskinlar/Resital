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

        public List<RoomTypeDTO> getAllRoomTypes()
        {
            var room = _uow.GetRepository<RoomType>().GetAll().ToList();
            return _mapper.Map<List<RoomTypeDTO>>(room);
        }

        public RoomTypeDTO getRoomType(int roomTypeId)
        {
            throw new NotImplementedException();
        }

        public List<RoomTypeDTO> getRoomTypeName(string roomTypeName)
        {
            throw new NotImplementedException();
        }

        public RoomTypeDTO addRoomType(RoomTypeDTO roomType)
        {
            throw new NotImplementedException();
        }

        public RoomTypeDTO updateRoomType(RoomTypeDTO roomType)
        {
            throw new NotImplementedException();
        }

        public bool deleteRoomType(int roomTypeId)
        {
            throw new NotImplementedException();
        }
    }
}