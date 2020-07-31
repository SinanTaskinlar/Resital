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
    public class RoomLocationService : IRoomLocationService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public RoomLocationService(IUnitOfWork uow, IMapper mapper)
        {
            this._mapper = mapper;
            this._uow = uow;
        }

        public List<RoomLocationDto> getAllRoomLocations()
        {
            var room = _uow.GetRepository<RoomLocation>().GetAll().ToList();
            return _mapper.Map<List<RoomLocationDto>>(room);
        }

        public RoomLocationDto getRoomLocation(Guid roomLocationId)
        {
            var room = _uow.GetRepository<RoomLocation>().GetById(roomLocationId);
            return _mapper.Map<RoomLocationDto>(room);
        }

        public RoomLocationDto addRoomLocation(RoomLocationDto roomLocation)
        {
            if (!_uow.GetRepository<RoomLocation>().GetAll().Any(z => z.Name == roomLocation.Name))
            {
                var room = _mapper.Map<City>(roomLocation);
                _uow.GetRepository<City>().Insert(room);
                _uow.SaveChanges();
                return _mapper.Map<RoomLocationDto>(room);
            }
            else
            {
                return null;
            }
        }

        public RoomLocationDto updateRoomLocation(RoomLocationDto roomLocation)
        {
            var room = _uow.GetRepository<RoomLocation>().GetById(roomLocation.Id);
            room = _mapper.Map<RoomLocation>(roomLocation);
            _uow.GetRepository<RoomLocation>().Update(room);
            _uow.SaveChanges();
            return _mapper.Map<RoomLocationDto>(room);
        }

        public bool deleteRoomLocation(Guid roomLocationId)
        {
            try
            {
                var room = _uow.GetRepository<RoomLocation>().GetById(roomLocationId);
                _uow.GetRepository<RoomLocation>().Delete(room.Id);
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