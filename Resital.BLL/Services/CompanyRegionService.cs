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
                _uow.GetRepository<CompanyRegion>().Add(companyRegion);
                _uow.SaveChanges();
                return _mapper.Map<CompanyRegionDTO>(companyRegion);
            }
            else
            {
                return null;
            }
        }

        public bool deleteCompanyRegion(int companyRegionId)
        {
            if (companyRegionId <= 0) throw new ArgumentOutOfRangeException(nameof(companyRegionId));
            try
            {
                var companyRegion = _uow.GetRepository<CompanyRegion>().Get(z => z.Id == companyRegionId);
                _uow.GetRepository<CompanyRegion>().Delete(companyRegion);
                _uow.SaveChanges();
                return true;
                //TODO: https://www.uzmankirala.com/projeler/goster/37840/web_sayfamiza_uyelik_kayit_ve_davet_sistemi SMS 
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

        public CompanyRegionDTO getCompanyRegion(int companyRegionId)
        {
            var companyRegion = _uow.GetRepository<CompanyRegion>().Get(z => z.Id == companyRegionId);
            return _mapper.Map<CompanyRegionDTO>(companyRegion);
        }

        public CompanyRegionDTO updateCompanyRegion(CompanyRegionDTO companyRegion)
        {
            var upCompanyRegion = _uow.GetRepository<CompanyRegion>().Get(z => z.Id == companyRegion.Id);
            upCompanyRegion = _mapper.Map<CompanyRegion>(companyRegion);
            _uow.GetRepository<CompanyRegion>().Update(upCompanyRegion);
            _uow.SaveChanges();
            return _mapper.Map<CompanyRegionDTO>(upCompanyRegion);
        }
    }
}
