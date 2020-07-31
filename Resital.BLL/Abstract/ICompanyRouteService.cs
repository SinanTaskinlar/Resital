using Resital.Core.Services;
using Resital.DTO;
using System;
using System.Collections.Generic;

namespace Resital.BLL.Abstract
{
    public interface ICompanyRouteService : IServiceBase
    {
        List<CompanyRouteDto> getAllCompanyRoutes();

        CompanyRouteDto getCompanyRoute(Guid companyRouteId);

        CompanyRouteDto addCompanyRoute(CompanyRouteDto companyRoute);

        CompanyRouteDto updateCompanyRoute(CompanyRouteDto companyRoute);

        bool deleteCompanyRoute(Guid companyRouteId);
    }
}