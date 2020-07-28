using Microsoft.AspNetCore.Mvc;
using Resital.BLL.Abstract;
using Resital.DTO;
using System;
using System.Collections.Generic;

namespace Resital.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ICityService _cityService;

        public CityController(ICityService cityService)
        {
            _cityService = cityService;
        }

        // GET: api/<CityController>
        [HttpGet]
        public List<CityDTO> Get()
        {
            return _cityService.getAllCities();
        }

        // GET api/<CityController>/5
        [HttpGet("{id}")]
        public CityDTO Get(Guid id)
        {
            return _cityService.getCity(id);
        }

        // POST api/<CityController>
        [HttpPost]
        public CityDTO Post(CityDTO cityDto)
        {
            return _cityService.addCity(cityDto);
        }

        // PUT api/<CityController>/5
        [HttpPut("{id}")]
        public CityDTO Put(CityDTO cityDTO)
        {
            return _cityService.updateCity(cityDTO);
        }

        // DELETE api/<CityController>/5
        [HttpDelete("{id}")]
        public bool Delete(Guid id)
        {
            return _cityService.deleteCity(id);
        }
    }
}