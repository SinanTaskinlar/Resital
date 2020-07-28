using Resital.Core.Services;
using Resital.DTO;
using System;
using System.Collections.Generic;

namespace Resital.BLL.Abstract
{
    public interface ICompanyRegionService : IServiceBase
    {
        List<CompanyRegionDTO> getAllCompanyRegions();

        CompanyRegionDTO getCompanyRegion(Guid cityId);

        CompanyRegionDTO addCompanyRegion(CompanyRegionDTO city);

        CompanyRegionDTO updateCompanyRegion(CompanyRegionDTO companyRegion);

        bool deleteCompanyRegion(Guid companyRegionId);
    }
}