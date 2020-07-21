using Resital.Core.Services;
using Resital.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Resital.BLL.Abstract
{
    public interface IRouteService : IServiceBase
    {
        List<RouteDTO> getAllRoutes();
        RouteDTO getRoute(int RouteId);
        List<RouteDTO> getRouteName(string RouteName);
        RouteDTO addRoute(RouteDTO Route);
        RouteDTO updateRoute(RouteDTO Route);
        bool deleteRoute(int RouteId);
    }
}
