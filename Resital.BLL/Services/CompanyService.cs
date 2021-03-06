﻿using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Resital.BLL.Abstract;
using Resital.Core.Data.UnitOfWork;
using Resital.DTO;
using Resital.Model;

namespace Resital.BLL.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public CompanyService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public List<CompanyDto> getAllCompanies()
        {
            var compList = _uow.GetRepository<Company>().GetAll().ToList();
            return _mapper.Map<List<CompanyDto>>(compList);
        }

        //  18fd0bac-5c0a-47ab-6c7c-08d83221d38f
        public CompanyDto getCompany(Guid companyId)
        {
            //var company = _uow.GetRepository<Company>().Get(z => z.Id == companyId, z => z.Rooms);
            //YORUM SATIRI
            var company = _uow.GetRepository<Company>().GetById(z => z.Id == companyId, z => z.Rooms);
            return _mapper.Map<CompanyDto>(company);
        }

        public CompanyDto addCompany(CompanyDto companyDto)
        {
            if (companyDto.Name != null)
            {
                var company = _mapper.Map<Company>(companyDto);
                _uow.GetRepository<Company>().Insert(company);
                _uow.SaveChanges();
                return _mapper.Map<CompanyDto>(company);
            }

            return null;
        }

        public CompanyDto updateCompany(CompanyDto company)
        {
            var upCompany = _uow.GetRepository<Company>().GetById(company.Id);
            upCompany = _mapper.Map<Company>(company);
            _uow.GetRepository<Company>().Update(upCompany);
            _uow.SaveChanges();
            return _mapper.Map<CompanyDto>(upCompany);
        }

        public bool deleteCompany(Guid companyId)
        {
            try
            {
                var company = _uow.GetRepository<Company>().GetById(companyId);
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