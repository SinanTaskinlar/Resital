using Resital.Core.Services;
using Resital.DTO;
using System;
using System.Collections.Generic;

namespace Resital.BLL.Abstract
{
    public interface ICompanyService : IServiceBase
    {
        List<CompanyDto> getAllCompanies();

        CompanyDto getCompany(Guid companyId);

        CompanyDto addCompany(CompanyDto companyDto);

        CompanyDto updateCompany(CompanyDto company);

        bool deleteCompany(Guid companyId);
    }
}