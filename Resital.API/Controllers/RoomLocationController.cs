using Microsoft.AspNetCore.Mvc;
using Resital.BLL.Abstract;
using Resital.DTO;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Resital.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomLocationController : ControllerBase
    {
        private readonly IRoomLocationService _roomLocationService;

        public RoomLocationController(IRoomLocationService roomLocation)
        {
            _roomLocationService = roomLocation;
        }

        // GET: api/<RoomLocationController>
        [HttpGet]
        public List<RoomLocationDTO> Get()
        {
            return _roomLocationService.getAllRoomLocations();
        }

        // GET api/<RoomLocationController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RoomLocationController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<RoomLocationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RoomLocationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}