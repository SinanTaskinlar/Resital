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
        RouteDTO getRoute(int routeId);
        List<RouteDTO> getRouteName(string routeName);
        RouteDTO addRoute(RouteDTO route);
        RouteDTO updateRoute(RouteDTO route);
        bool deleteRoute(int routeId);
    }
}
