using Resital.Core.Services;
using Resital.DTO;
using System;
using System.Collections.Generic;

namespace Resital.BLL.Abstract
{
    public interface IRouteService : IServiceBase
    {
        List<RouteDto> getAllRoutes();

        RouteDto getRoute(Guid routeId);

        RouteDto addRoute(RouteDto route);

        RouteDto updateRoute(RouteDto route);

        bool deleteRoute(Guid routeId);
    }
}