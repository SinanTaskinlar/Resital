using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Resital.BLL.Abstract;
using Resital.DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Resital.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomTypeController : ControllerBase
    {
        private readonly IRoomTypeService _roomTypeService;

        public RoomTypeController(IRoomTypeService roomTypeService)
        {
            _roomTypeService = roomTypeService;
        }

        // GET: api/<RoomTypeController>
        [HttpGet]
        public List<RoomTypeDto> Get()
        {
            return _roomTypeService.getAllRoomTypes();
        }

        // GET api/<RoomTypeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RoomTypeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<RoomTypeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RoomTypeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}