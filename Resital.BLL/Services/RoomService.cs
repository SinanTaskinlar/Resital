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
    public class RoomService : IRoomService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public RoomService(IUnitOfWork uow, IMapper mapper)
        {
            this._mapper = mapper;
            this._uow = uow;
        }

        public List<RoomDTO> getAllRooms()
        {
            var room = _uow.GetRepository<Room>().GetAll().ToList();
            return _mapper.Map<List<RoomDTO>>(room);
        }

        public RoomDTO getRoom(Guid roomId)
        {
            var room = _uow.GetRepository<Room>().GetById(roomId);
            return _mapper.Map<RoomDTO>(room);
        }

        public RoomDTO addRoom(RoomDTO roomDto)
        {
            var room = _mapper.Map<Room>(roomDto);
            _uow.GetRepository<Room>().Insert(room);
            _uow.SaveChanges();
            return _mapper.Map<RoomDTO>(room);
        }

        public RoomDTO updateRoom(RoomDTO roomDto)
        {
            var room = _uow.GetRepository<Room>().GetById(roomDto.Id);
            room = _mapper.Map<Room>(roomDto);
            _uow.GetRepository<Room>().Update(room);
            _uow.SaveChanges();
            return _mapper.Map<RoomDTO>(room);
        }

        public bool deleteRoom(Guid roomId)
        {
            try
            {
                var room = _uow.GetRepository<Room>().GetById(roomId);
                _uow.GetRepository<Room>().Delete(room.Id);
                _uow.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}