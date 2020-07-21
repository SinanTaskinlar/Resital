using Resital.Core.Services;
using Resital.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Resital.BLL.Abstract
{
    public interface ICompanyRegionService : IServiceBase
    {
        List<CompanyRegionDTO> getAllCompanyRegions();
        CompanyRegionDTO getCompanyRegion(int cityId);
        CompanyRegionDTO addCompanyRegion(CompanyRegionDTO city);
        CompanyRegionDTO updateCompanyRegion(CompanyRegionDTO companyRegion);
        bool deleteCompanyRegion(int companyRegionId);
    }
}
