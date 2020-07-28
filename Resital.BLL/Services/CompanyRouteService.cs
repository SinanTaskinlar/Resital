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

        public CompanyRouteDTO addCompanyRoute(CompanyRouteDTO companyRoute)
        {
            CompanyRoute Guide = _mapper.Map<CompanyRoute>(companyRoute);
            _uow.GetRepository<CompanyRoute>().Insert(Guide);
            _uow.SaveChanges();
            return _mapper.Map<CompanyRouteDTO>(Guide);
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

        public List<CompanyRouteDTO> getAllCompanyRoutes()
        {
            return _mapper.Map<List<CompanyRouteDTO>>(_uow.GetRepository<CompanyRoute>().GetAll().ToList());
        }

        public CompanyRouteDTO getCompanyRoute(Guid companyRouteId)
        {
            var city = _uow.GetRepository<CompanyRoute>().GetById(companyRouteId);
            return _mapper.Map<CompanyRouteDTO>(city);
        }

        public CompanyRouteDTO updateCompanyRoute(CompanyRouteDTO companyRoute)
        {
            var upCity = _uow.GetRepository<CompanyRoute>().GetById(companyRoute.Id);
            upCity = _mapper.Map<CompanyRoute>(companyRoute);
            _uow.GetRepository<CompanyRoute>().Update(upCity);
            _uow.SaveChanges();
            return _mapper.Map<CompanyRouteDTO>(upCity);
        }
    }
}