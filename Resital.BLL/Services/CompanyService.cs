using Resital.BLL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Resital.Core.Data.UnitOfWork;
using Resital.DTO;
using Resital.Model;

namespace Resital.BLL.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public CompanyService(IUnitOfWork uow, IMapper mapper)
        {
            this._uow = uow;
            this._mapper = mapper;
        }

        public List<CompanyDTO> getAllCompanies()
        {
            return _mapper.Map<List<CompanyDTO>>(_uow.GetRepository<Company>().GetAll().ToList());
        }

        public CompanyDTO getCompanyRoute(int companyId)
        {
            throw new NotImplementedException();
        }   

        public List<CompanyDTO> getCompanyName(string companyName)
        {
            var cityList = _uow.GetRepository<Company>().Get(z => z.Name.Contains(companyName), null).ToList();
            return _mapper.Map<List<CompanyDTO>>(cityList);
        }

        public CompanyDTO addCompany(CompanyDTO companyDto)
        {
            if (!_uow.GetRepository<CompanyRegion>().GetAll().Any(z => z.Company.Name == companyDto.Name))
            {
                var company = _mapper.Map<Company>(companyDto);
                _uow.GetRepository<Company>().Add(company);
                _uow.SaveChanges();
                return _mapper.Map<CompanyDTO>(company);
            }
            else
            {
                return null;
            }
        }

        public CompanyDTO updateCompany(CompanyDTO company)
        {
            var upCompany = _uow.GetRepository<Company>().Get(z => z.Id == company.Id);
            upCompany = _mapper.Map<Company>(company);
            _uow.GetRepository<Company>().Update(upCompany);
            _uow.SaveChanges();
            return _mapper.Map<CompanyDTO>(upCompany);
        }

        public bool deleteCompany(int companyId)
        {
            if (companyId <= 0) throw new ArgumentOutOfRangeException(nameof(companyId));
            try
            {
                var Company = _uow.GetRepository<Company>().Get(z => z.Id == companyId);
                _uow.GetRepository<Company>().Delete(Company);
                _uow.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
