using System;
using System.Collections.Generic;
using Resital.Core.Services;
using Resital.DTO;

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