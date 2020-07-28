using Resital.Core.Services;
using Resital.DTO;
using System;
using System.Collections.Generic;

namespace Resital.BLL.Abstract
{
    public interface IRouteService : IServiceBase
    {
        List<RouteDTO> getAllRoutes();

        RouteDTO getRoute(Guid routeId);

        RouteDTO addRoute(RouteDTO route);

        RouteDTO updateRoute(RouteDTO route);

        bool deleteRoute(Guid routeId);
    }
}