using Resital.Core.Services;
using Resital.DTO;
using System;
using System.Collections.Generic;

namespace Resital.BLL.Abstract
{
    public interface ICompanyRouteService : IServiceBase
    {
        List<CompanyRouteDTO> getAllCompanyRoutes();

        CompanyRouteDTO getCompanyRoute(Guid companyRouteId);

        CompanyRouteDTO addCompanyRoute(CompanyRouteDTO companyRoute);

        CompanyRouteDTO updateCompanyRoute(CompanyRouteDTO companyRoute);

        bool deleteCompanyRoute(Guid companyRouteId);
    }
}