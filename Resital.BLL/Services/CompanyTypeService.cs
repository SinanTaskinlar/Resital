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

        public CompanyTypeDTO getCompanyType(Guid companyRouteId)
        {
            var companyType = _uow.GetRepository<CompanyType>().GetById(companyRouteId);
            return _mapper.Map<CompanyTypeDTO>(companyType);
        }

        public CompanyTypeDTO addCompanyType(CompanyTypeDTO companyType)
        {
            if (!_uow.GetRepository<CompanyType>().GetAll().Any(z => z.TypeName == companyType.TypeName))
            {
                var city = _mapper.Map<CompanyType>(companyType);
                _uow.GetRepository<CompanyType>().Insert(city);
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
            CompanyType companyType = _uow.GetRepository<CompanyType>().GetById(companyTypeDto.Id);
            companyType = _mapper.Map<CompanyType>(companyTypeDto);
            _uow.GetRepository<CompanyType>().Update(companyType);
            _uow.SaveChanges();
            return _mapper.Map<CompanyTypeDTO>(companyType);
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