using AutoMapper;
using Resital.BLL.Abstract;
using Resital.Core.Data.UnitOfWork;
using Resital.DTO;
using Resital.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Resital.BLL.Services
{
    public class CompanyRegionService : ICompanyRegionService
    {
        private readonly IUnitOfWork uow;
        private readonly IMapper mapper;

        public CompanyRegionService(IUnitOfWork _uow, IMapper _mapper)
        {
            uow = _uow;
            mapper = _mapper;
        }

        public CompanyRegionDTO addCompanyRegion(CompanyRegionDTO companyRegionDTO)
        {
            if (!uow.GetRepository<CompanyRegion>().GetAll().Any(z => z.Company == companyRegionDTO.Company))
            {
                CompanyRegion CompanyRegion = mapper.Map<CompanyRegion>(companyRegionDTO);
                uow.GetRepository<CompanyRegion>().Add(CompanyRegion);
                uow.SaveChanges();
                return mapper.Map<CompanyRegionDTO>(CompanyRegion);
            }
            else
            {
                return null;
            }
        }

        public bool deleteCompanyRegion(int companyRegionId)
        {
            try
            {
                var CompanyRegion = uow.GetRepository<CompanyRegion>().Get(z => z.Id == companyRegionId);
                uow.GetRepository<CompanyRegion>().Delete(CompanyRegion);
                uow.SaveChanges();
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
            var articleList = uow.GetRepository<CompanyRegion>().GetAll().ToList();
            return mapper.Map<List<CompanyRegionDTO>>(articleList);
        }

        public CompanyRegionDTO getCompanyRegion(int CompanyRegionId)
        {
            var CompanyRegion = uow.GetRepository<CompanyRegion>().Get(z => z.Id == CompanyRegionId);
            return mapper.Map<CompanyRegionDTO>(CompanyRegion);
        }

        public CompanyRegionDTO updateCompanyRegion(CompanyRegionDTO companyRegion)
        {
            var upCompanyRegion = uow.GetRepository<CompanyRegion>().Get(z => z.Id == companyRegion.Id);
            upCompanyRegion = mapper.Map<CompanyRegion>(companyRegion);
            uow.GetRepository<CompanyRegion>().Update(upCompanyRegion);
            uow.SaveChanges();
            return mapper.Map<CompanyRegionDTO>(upCompanyRegion);
        }
    }
}
