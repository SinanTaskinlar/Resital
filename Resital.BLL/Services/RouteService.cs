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
    public class RouteService : IRouteService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public RouteService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public List<RouteDto> getAllRoutes()
        {
            return _mapper.Map<List<RouteDto>>(_uow.GetRepository<Route>().GetAll().ToList());
        }

        public RouteDto getRoute(Guid routeId)
        {
            var route = _uow.GetRepository<Route>().GetById(routeId);
            return _mapper.Map<RouteDto>(route);
        }

        public RouteDto addRoute(RouteDto route)
        {
            if (!_uow.GetRepository<Route>().GetAll().Any(z => z.Name == route.Name))
            {
                var company = _mapper.Map<Route>(route);
                _uow.GetRepository<Route>().Insert(company);
                _uow.SaveChanges();
                return _mapper.Map<RouteDto>(company);
            }

            return null;
        }

        public RouteDto updateRoute(RouteDto route)
        {
            var upCompanyRegion = _uow.GetRepository<Route>().GetById(route.Id);
            upCompanyRegion = _mapper.Map<Route>(route);
            _uow.GetRepository<Route>().Update(upCompanyRegion);
            _uow.SaveChanges();
            return _mapper.Map<RouteDto>(upCompanyRegion);
        }

        public bool deleteRoute(Guid routeId)
        {
            try
            {
                var company = _uow.GetRepository<Route>().GetById(routeId);
                _uow.GetRepository<Route>().Delete(company.Id);
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