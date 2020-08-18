using System;
using System.Collections.Generic;
using Resital.Core.Services;
using Resital.DTO;

namespace Resital.BLL.Abstract
{
    public interface ICompanyTypeService : IServiceBase
    {
        List<CompanyTypeDto> getAllCompanyTypes();

        CompanyTypeDto getCompanyType(Guid companyRouteId);

        CompanyTypeDto addCompanyType(CompanyTypeDto companyType);

        CompanyTypeDto updateCompanyType(CompanyTypeDto companyType);

        bool deleteCompanyType(Guid companyTypeId);
    }
}