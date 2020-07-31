using Microsoft.AspNetCore.Mvc;
using Resital.BLL.Abstract;
using Resital.DTO;
using System;
using System.Collections.Generic;

namespace Resital.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _companyService;

        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        // GET: api/<CompanyController>
        [HttpGet]
        public List<CompanyDto> Get()
        {
            return _companyService.getAllCompanies();
        }

        // GET api/<CompanyController>/5
        [HttpGet("{id}")]
        public CompanyDto Get(Guid id)
        {
            return _companyService.getCompany(id);
        }

        // POST api/<CompanyController>
        [HttpPost]
        public CompanyDto Post(CompanyDto companyDto)
        {
            return _companyService.addCompany(companyDto);
        }

        // PUT api/<CompanyController>/5
        [HttpPut("{id}")]
        public CompanyDto Put(CompanyDto companyDto)
        {
            return _companyService.updateCompany(companyDto);
        }

        // DELETE api/<CompanyController>/5
        [HttpDelete("{id}")]
        public bool Delete(Guid id)
        {
            return _companyService.deleteCompany(id);
        }
    }
}