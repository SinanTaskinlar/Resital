using System;
using System.Collections.Generic;
using Resital.Core.Services;
using Resital.DTO;

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