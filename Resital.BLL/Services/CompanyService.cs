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
    public class CompanyService : ICompanyService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public CompanyService(IUnitOfWork uow, IMapper mapper)
        {
            this._uow = uow;
            this._mapper = mapper;
        }

        public List<CompanyDTO> getAllCompanies()
        {
            var compList = _uow.GetRepository<Company>().GetAll().ToList();
            return _mapper.Map<List<CompanyDTO>>(compList);
        }
        //  18fd0bac-5c0a-47ab-6c7c-08d83221d38f
        public CompanyDTO getCompany(Guid companyId)
        {
            //var company = _uow.GetRepository<Company>().Get(z => z.Id == companyId, z => z.Rooms);
            var company = _uow.GetRepository<Company>().GetById(z => z.Id == companyId, z => z.Rooms);
            Company x = company.FirstOrDefault();
            return _mapper.Map<CompanyDTO>(company.FirstOrDefault());
        }

        public CompanyDTO addCompany(CompanyDTO companyDto)
        {
            if (companyDto.Name != null)
            {
                var company = _mapper.Map<Company>(companyDto);
                _uow.GetRepository<Company>().Insert(company);
                _uow.SaveChanges();
                return _mapper.Map<CompanyDTO>(company);
            }
            else
            {
                return null;
            }
        }

        public CompanyDTO updateCompany(CompanyDTO company)
        {
            var upCompany = _uow.GetRepository<Company>().GetById(company.Id);
            upCompany = _mapper.Map<Company>(company);
            _uow.GetRepository<Company>().Update(upCompany);
            _uow.SaveChanges();
            return _mapper.Map<CompanyDTO>(upCompany);
        }

        public bool deleteCompany(Guid companyId)
        {
            try
            {
                var Company = _uow.GetRepository<Company>().GetById(companyId);
                _uow.GetRepository<Company>().Delete(companyId);
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


//{
//"id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
//"name": "string",
//"address": "string",
//"note": "string",
//"companyTypeId": "8eed50c9-be02-4ff2-9f25-a25d84e5690f"
//}