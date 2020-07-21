using Resital.Core.Services;
using Resital.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Resital.BLL.Abstract
{
    public interface ICompanyRouteService : IServiceBase
    {
        List<CompanyRouteDTO> getAllCompanyRoutes();
        CompanyRouteDTO getCompanyRoute(int companyRouteId);
        List<CompanyRouteDTO> getCompanyRouteName(string companyRouteName);
        CompanyRouteDTO addCompanyRoute(CompanyRouteDTO companyRoute);
        CompanyRouteDTO updateCompanyRoute(CompanyRouteDTO companyRoute);
        bool deleteCompanyRoute(int companyRouteId);
    }
}
