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
    public class CompanyRouteService : ICompanyRouteService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public CompanyRouteService(IUnitOfWork uow, IMapper mapper)
        {
            this._uow = uow;
            this._mapper = mapper;
        }

        public CompanyRouteDto addCompanyRoute(CompanyRouteDto companyRoute)
        {
            CompanyRoute guide = _mapper.Map<CompanyRoute>(companyRoute);
            _uow.GetRepository<CompanyRoute>().Insert(guide);
            _uow.SaveChanges();
            return _mapper.Map<CompanyRouteDto>(guide);
        }

        public bool deleteCompanyRoute(Guid companyRouteId)
        {
            try
            {
                _uow.GetRepository<CompanyRoute>().Delete(companyRouteId);
                _uow.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<CompanyRouteDto> getAllCompanyRoutes()
        {
            return _mapper.Map<List<CompanyRouteDto>>(_uow.GetRepository<CompanyRoute>().GetAll().ToList());
        }

        public CompanyRouteDto getCompanyRoute(Guid companyRouteId)
        {
            var city = _uow.GetRepository<CompanyRoute>().GetById(companyRouteId);
            return _mapper.Map<CompanyRouteDto>(city);
        }

        public CompanyRouteDto updateCompanyRoute(CompanyRouteDto companyRoute)
        {
            var upCity = _uow.GetRepository<CompanyRoute>().GetById(companyRoute.Id);
            upCity = _mapper.Map<CompanyRoute>(companyRoute);
            _uow.GetRepository<CompanyRoute>().Update(upCity);
            _uow.SaveChanges();
            return _mapper.Map<CompanyRouteDto>(upCity);
        }
    }
}