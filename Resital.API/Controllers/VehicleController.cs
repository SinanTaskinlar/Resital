using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Resital.BLL.Abstract;
using Resital.DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Resital.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleService _vehicleService;

        public VehicleController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }

        // GET: api/<VehiclesController>
        [HttpGet]
        public List<VehicleDto> Get()
        {
            return _vehicleService.getAllVehicles();
        }

        // GET api/<VehiclesController>/5
        [HttpGet("{id}")]
        public VehicleDto Get(Guid id)
        {
            return _vehicleService.getVehicle(id);
        }

        // POST api/<VehiclesController>
        [HttpPost]
        public VehicleDto Post(VehicleDto vehicleDto)
        {
            return _vehicleService.addVehicle(vehicleDto);
        }

        // PUT api/<VehiclesController>/5
        [HttpPut("{id}")]
        public VehicleDto Put(VehicleDto vehicleDto)
        {
            return _vehicleService.updateVehicle(vehicleDto);
        }

        // DELETE api/<VehiclesController>/5
        [HttpDelete("{id}")]
        public bool Delete(Guid id)
        {
            return _vehicleService.deleteVehicle(id);
        }
    }
}