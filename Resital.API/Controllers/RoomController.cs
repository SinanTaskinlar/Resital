using Microsoft.AspNetCore.Mvc;
using Resital.BLL.Abstract;
using Resital.DTO;
using System;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Resital.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;

        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        // GET: api/<RoomController>
        [HttpGet]
        public List<RoomDto> Get()
        {
            return _roomService.getAllRooms();
        }

        // GET api/<RoomController>/5
        [HttpGet("{id}")]
        public RoomDto Get(Guid id)
        {
            return _roomService.getRoom(id);
        }

        // POST api/<RoomController>
        [HttpPost]
        public RoomDto Post(RoomDto roomDto)
        {
            return _roomService.addRoom(roomDto);
        }

        // PUT api/<RoomController>
        [HttpPut]
        public RoomDto Put(RoomDto roomDto)
        {
            return _roomService.updateRoom(roomDto);
        }

        // DELETE api/<RoomController>/5
        [HttpDelete("{id}")]
        public bool Delete(Guid id)
        {
            return _roomService.deleteRoom(id);
        }
    }
}