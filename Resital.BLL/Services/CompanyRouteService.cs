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
    public class CompanyRouteService : ICompanyRouteService
    {
        private readonly IUnitOfWork uow;
        private readonly IMapper mapper;

        public CompanyRouteService(IUnitOfWork _uow, IMapper _mapper)
        {
            uow = _uow;
            mapper = _mapper;
        }

        public CompanyRouteDTO addCompanyRoute(CompanyRouteDTO companyRoute)
        {
                CompanyRoute Guide = mapper.Map<CompanyRoute>(companyRoute);
                uow.GetRepository<CompanyRoute>().Add(Guide);//todo: int guid
                uow.SaveChanges();
                return mapper.Map<CompanyRouteDTO>(Guide);
        }

        public bool deleteCompanyRoute(int companyRouteId)
        {
            try
            {
                uow.GetRepository<CompanyRoute>().Delete(uow.GetRepository<CompanyRoute>().Get(z => z.Id == companyRouteId));
                uow.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<CompanyRouteDTO> getAllCompanyRoutes()
        {
            return mapper.Map<List<CompanyRouteDTO>>(uow.GetRepository<CompanyRoute>().GetAll().ToList());
        }

        public CompanyRouteDTO getCompanyRoute(int companyRouteId)
        {
            var city = uow.GetRepository<CompanyRoute>().Get(z => z.Id == companyRouteId);
            return mapper.Map<CompanyRouteDTO>(city);
        }

        public List<CompanyRouteDTO> getCompanyRouteName(string companyRouteName)
        {
            var cityList = uow.GetRepository<CompanyRoute>().Get(z => z.Company.Name.Contains(companyRouteName), null).ToList();
            return mapper.Map<List<CompanyRouteDTO>>(cityList);
        }

        public CompanyRouteDTO updateCompanyRoute(CompanyRouteDTO companyRoute)
        {
            var upCity = uow.GetRepository<CompanyRoute>().Get(z => z.Id == companyRoute.Id);
            upCity = mapper.Map<CompanyRoute>(companyRoute);
            uow.GetRepository<CompanyRoute>().Update(upCity);
            uow.SaveChanges();
            return mapper.Map<CompanyRouteDTO>(upCity);
        }
    }
}
