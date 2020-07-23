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
    public class CompanyTypeService : ICompanyTypeService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public CompanyTypeService(IMapper mapper, IUnitOfWork uow)
        {
            this._mapper = mapper;
            this._uow = uow;
        }
        
        public List<CompanyTypeDTO> getAllCompanyTypes()
        {
            return _mapper.Map<List<CompanyTypeDTO>>(_uow.GetRepository<CompanyType>().GetAll().ToList());
        }

        public CompanyTypeDTO getCompanyType(int companyRouteId)
        {
            var companyType = _uow.GetRepository<CompanyType>().Get(z => z.Id == companyRouteId);
            return _mapper.Map<CompanyTypeDTO>(companyType);
        }

        public List<CompanyTypeDTO> getCompanyTypeName(string companyTypeName)
        {
            var companyTypeList = _uow.GetRepository<CompanyType>().Get(z => z.TypeName.Contains(companyTypeName), null).ToList();
            return _mapper.Map<List<CompanyTypeDTO>>(companyTypeList);
        }

        public CompanyTypeDTO addCompanyType(CompanyTypeDTO companyType)
        {
            if (!_uow.GetRepository<CompanyType>().GetAll().Any(z => z.TypeName == companyType.TypeName))
            {
                var city = _mapper.Map<CompanyType>(companyType);
                _uow.GetRepository<CompanyType>().Add(city);
                _uow.SaveChanges();
                return _mapper.Map<CompanyTypeDTO>(city);
            }
            else
            {
                return null;
            }
        }

        public CompanyTypeDTO updateCompanyType(CompanyTypeDTO companyTypeDto)
        {
            CompanyType companyType = _uow.GetRepository<CompanyType>().Get(z => z.Id == companyTypeDto.Id);
            companyType = _mapper.Map<CompanyType>(companyTypeDto);
            _uow.GetRepository<CompanyType>().Update(companyType);
            _uow.SaveChanges();
            return _mapper.Map<CompanyTypeDTO>(companyType);
        }

        public bool deleteCompanyType(int companyTypeId)
        {
            try
            {
                var companyType = _uow.GetRepository<CompanyType>().Get(z => z.Id == companyTypeId);
                _uow.GetRepository<CompanyType>().Delete(companyType);
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