using Microsoft.AspNetCore.Mvc;
using Resital.BLL.Abstract;
using Resital.DTO;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Resital.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyTypeController : ControllerBase
    {
        private readonly ICompanyTypeService _companyTypeService;

        public CompanyTypeController(ICompanyTypeService companyTypeService)
        {
            _companyTypeService = companyTypeService;
        }

        // GET: api/<CompanyTypeController>
        [HttpGet]
        public List<CompanyTypeDto> Get()
        {
            return _companyTypeService.getAllCompanyTypes();
        }

        // GET api/<CompanyTypeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CompanyTypeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CompanyTypeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CompanyTypeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}