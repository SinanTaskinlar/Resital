using System;
using System.Collections.Generic;
using AutoMapper;
using Resital.BLL.Abstract;
using Resital.Core.Data.UnitOfWork;
using Resital.DTO;
using Resital.Model;
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

        public RouteDTO getRoute(int routeId)
        {
            var route = _uow.GetRepository<Route>().Get(z => z.Id == routeId);
            return _mapper.Map<RouteDTO>(route);
        }

        public List<RouteDTO> getRouteName(string routeName)
        {
            var cityList = _uow.GetRepository<Route>().Get(z => z.Name.Contains(routeName), null).ToList();
            return _mapper.Map<List<RouteDTO>>(cityList);
        }

        public RouteDTO addRoute(RouteDTO route)
        {
            if (!_uow.GetRepository<Route>().GetAll().Any(z => z.Name == route.Name))
            {
                var company = _mapper.Map<Route>(route);
                _uow.GetRepository<Route>().Add(company);
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
            var upCompanyRegion = _uow.GetRepository<Route>().Get(z => z.Id == route.Id);
            upCompanyRegion = _mapper.Map<Route>(route);
            _uow.GetRepository<Route>().Update(upCompanyRegion);
            _uow.SaveChanges();
            return _mapper.Map<RouteDTO>(upCompanyRegion);
        }

        public bool deleteRoute(int routeId)
        {
            if (routeId <= 0) throw new ArgumentOutOfRangeException(nameof(routeId));
            try
            {
                var Company = _uow.GetRepository<Route>().Get(z => z.Id == routeId);
                _uow.GetRepository<Route>().Delete(Company);
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