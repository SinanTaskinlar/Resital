using Resital.Core.Services;
using Resital.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Resital.BLL.Abstract
{
    public interface ICompanyTypeService : IServiceBase
    {
        List<CompanyTypeDTO> getAllCompanyTypes();
        CompanyTypeDTO getCompanyType(int companyRouteId);
        List<CompanyTypeDTO> getCompanyTypeName(string companyTypeName);
        CompanyTypeDTO addCompanyType(CompanyTypeDTO companyType);
        CompanyTypeDTO updateCompanyType(CompanyTypeDTO companyType);
        bool deleteCompanyType(int companyTypeId);
    }
}
