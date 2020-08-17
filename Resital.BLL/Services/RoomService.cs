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

        public List<RoomDto> getAllRooms()
        {
            var rooms = _uow.GetRepository<Room>().GetAll().ToList();
            foreach (var room in rooms)
            {
                room.Company = _uow.GetRepository<Company>().GetById(room.CompanyId);
                room.RoomLocation = _uow.GetRepository<RoomLocation>().GetById(room.RoomLocationId);
                room.RoomType = _uow.GetRepository<RoomType>().GetById(room.RoomTypeId);
            }
            return _mapper.Map<List<RoomDto>>(rooms);
        }

        public RoomDto getRoom(Guid roomId)
        {
            var room = _uow.GetRepository<Room>().GetById(roomId);
            return _mapper.Map<RoomDto>(room);
        }

        public RoomDto addRoom(RoomDto roomDto)
        {
            roomDto.Company = _uow.GetRepository<Company>().GetById(roomDto.CompanyId);
            roomDto.RoomLocation = _uow.GetRepository<RoomLocation>().GetById(roomDto.RoomLocationId);
            roomDto.RoomType = _uow.GetRepository<RoomType>().GetById(roomDto.RoomTypeId);
            var room = _mapper.Map<Room>(roomDto);
            _uow.GetRepository<Room>().Insert(room);
            _uow.SaveChanges();
            return _mapper.Map<RoomDto>(room);
        }

        public RoomDto updateRoom(RoomDto roomDto)
        {
            var room = _uow.GetRepository<Room>().GetById(roomDto.Id);
            room = _mapper.Map<Room>(roomDto);
            _uow.GetRepository<Room>().Update(room);
            _uow.SaveChanges();
            return _mapper.Map<RoomDto>(room);
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