using Resital.Core.Services;
using Resital.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Resital.BLL.Abstract
{
    public interface ICompanyService : IServiceBase
    {
        List<CompanyDTO> getAllCompanies();
        CompanyDTO getCompanyRoute(int companyId);
        List<CompanyDTO> getCompanyName(string companyName);
        CompanyDTO addCompany(CompanyDTO companyDto);
        CompanyDTO updateCompany(CompanyDTO company);
        bool deleteCompany(int companyId);
    }
}
