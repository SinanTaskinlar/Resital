using Resital.Core.Services;
using Resital.DTO;
using System;
using System.Collections.Generic;

namespace Resital.BLL.Abstract
{
    public interface ICompanyService : IServiceBase
    {
        List<CompanyDTO> getAllCompanies();

        CompanyDTO getCompany(Guid companyId);

        CompanyDTO addCompany(CompanyDTO companyDto);

        CompanyDTO updateCompany(CompanyDTO company);

        bool deleteCompany(Guid companyId);
    }
}