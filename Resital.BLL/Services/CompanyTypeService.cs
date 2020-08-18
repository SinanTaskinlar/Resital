using System;
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
            _mapper = mapper;
            _uow = uow;
        }

        public List<CompanyTypeDto> getAllCompanyTypes()
        {
            return _mapper.Map<List<CompanyTypeDto>>(_uow.GetRepository<CompanyType>().GetAll().ToList());
        }

        public CompanyTypeDto getCompanyType(Guid companyRouteId)
        {
            var companyType = _uow.GetRepository<CompanyType>().GetById(companyRouteId);
            return _mapper.Map<CompanyTypeDto>(companyType);
        }

        public CompanyTypeDto addCompanyType(CompanyTypeDto companyType)
        {
            if (!_uow.GetRepository<CompanyType>().GetAll().Any(z => z.TypeName == companyType.TypeName))
            {
                var city = _mapper.Map<CompanyType>(companyType);
                _uow.GetRepository<CompanyType>().Insert(city);
                _uow.SaveChanges();
                return _mapper.Map<CompanyTypeDto>(city);
            }

            return null;
        }

        public CompanyTypeDto updateCompanyType(CompanyTypeDto companyTypeDto)
        {
            var companyType = _uow.GetRepository<CompanyType>().GetById(companyTypeDto.Id);
            companyType = _mapper.Map<CompanyType>(companyTypeDto);
            _uow.GetRepository<CompanyType>().Update(companyType);
            _uow.SaveChanges();
            return _mapper.Map<CompanyTypeDto>(companyType);
        }

        public bool deleteCompanyType(Guid companyTypeId)
        {
            try
            {
                var companyType = _uow.GetRepository<CompanyType>().GetById(companyTypeId);
                _uow.GetRepository<CompanyType>().Delete(companyType.Id);
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