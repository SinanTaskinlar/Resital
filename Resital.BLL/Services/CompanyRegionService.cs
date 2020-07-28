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
    public class CompanyRegionService : ICompanyRegionService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public CompanyRegionService(IUnitOfWork uow, IMapper mapper)
        {
            this._uow = uow;
            this._mapper = mapper;
        }

        public CompanyRegionDTO addCompanyRegion(CompanyRegionDTO companyRegionDto)
        {
            if (!_uow.GetRepository<CompanyRegion>().GetAll().Any(z => z.Company == companyRegionDto.Company))
            {
                var companyRegion = _mapper.Map<CompanyRegion>(companyRegionDto);
                _uow.GetRepository<CompanyRegion>().Insert(companyRegion);
                _uow.SaveChanges();
                return _mapper.Map<CompanyRegionDTO>(companyRegion);
            }
            else
            {
                return null;
            }
        }

        public bool deleteCompanyRegion(Guid companyRegionId)
        {
            try
            {
                var companyRegion = _uow.GetRepository<CompanyRegion>().GetById(companyRegionId);
                _uow.GetRepository<CompanyRegion>().Delete(companyRegion.Id);
                _uow.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<CompanyRegionDTO> getAllCompanyRegions()
        {
            var articleList = _uow.GetRepository<CompanyRegion>().GetAll().ToList();
            return _mapper.Map<List<CompanyRegionDTO>>(articleList);
        }

        public CompanyRegionDTO getCompanyRegion(Guid companyRegionId)
        {
            var companyRegion = _uow.GetRepository<CompanyRegion>().GetById(companyRegionId);
            return _mapper.Map<CompanyRegionDTO>(companyRegion);
        }

        public CompanyRegionDTO updateCompanyRegion(CompanyRegionDTO companyRegion)
        {
            var upCompanyRegion = _uow.GetRepository<CompanyRegion>().GetById(companyRegion.Id);
            upCompanyRegion = _mapper.Map<CompanyRegion>(companyRegion);
            _uow.GetRepository<CompanyRegion>().Update(upCompanyRegion);
            _uow.SaveChanges();
            return _mapper.Map<CompanyRegionDTO>(upCompanyRegion);
        }
    }
}