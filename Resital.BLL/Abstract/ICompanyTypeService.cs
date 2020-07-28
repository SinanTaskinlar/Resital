using Resital.Core.Services;
using Resital.DTO;
using System;
using System.Collections.Generic;

namespace Resital.BLL.Abstract
{
    public interface ICompanyTypeService : IServiceBase
    {
        List<CompanyTypeDTO> getAllCompanyTypes();

        CompanyTypeDTO getCompanyType(Guid companyRouteId);

        CompanyTypeDTO addCompanyType(CompanyTypeDTO companyType);

        CompanyTypeDTO updateCompanyType(CompanyTypeDTO companyType);

        bool deleteCompanyType(Guid companyTypeId);
    }
}