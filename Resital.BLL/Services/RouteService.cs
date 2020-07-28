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
    public class RouteService : IRouteService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public RouteService(IUnitOfWork uow, IMapper mapper)
        {
            this._uow = uow;
            this._mapper = mapper;
        }

        public List<RouteDTO> getAllRoutes()
        {
            return _mapper.Map<List<RouteDTO>>(_uow.GetRepository<Route>().GetAll().ToList());
        }

        public RouteDTO getRoute(Guid routeId)
        {
            var route = _uow.GetRepository<Route>().GetById(routeId);
            return _mapper.Map<RouteDTO>(route);
        }

        public RouteDTO addRoute(RouteDTO route)
        {
            if (!_uow.GetRepository<Route>().GetAll().Any(z => z.Name == route.Name))
            {
                var company = _mapper.Map<Route>(route);
                _uow.GetRepository<Route>().Insert(company);
                _uow.SaveChanges();
                return _mapper.Map<RouteDTO>(company);
            }
            else
            {
                return null;
            }
        }

        public RouteDTO updateRoute(RouteDTO route)
        {
            var upCompanyRegion = _uow.GetRepository<Route>().GetById(route.Id);
            upCompanyRegion = _mapper.Map<Route>(route);
            _uow.GetRepository<Route>().Update(upCompanyRegion);
            _uow.SaveChanges();
            return _mapper.Map<RouteDTO>(upCompanyRegion);
        }

        public bool deleteRoute(Guid routeId)
        {
            try
            {
                var Company = _uow.GetRepository<Route>().GetById(routeId);
                _uow.GetRepository<Route>().Delete(Company.Id);
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