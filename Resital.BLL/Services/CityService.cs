using AutoMapper;
using Resital.BLL.Abstract;
using Resital.Core.Data.UnitOfWork;
using Resital.DTO;
using Resital.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Resital.BLL.Services
{
    public class CityService : ICityService
    {
        private readonly IUnitOfWork uow;
        private readonly IMapper mapper;

        public CityService(IUnitOfWork _uow, IMapper _mapper)
        {
            uow = _uow;
            mapper = _mapper;
        }

        public CityDTO addCity(CityDTO cityDto)
        {
            if (!uow.GetRepository<City>().GetAll().Any(z => z.Name == cityDto.Name))
            {
                City City = mapper.Map<City>(cityDto);
                uow.GetRepository<City>().Add(City);
                uow.SaveChanges();
                return mapper.Map<CityDTO>(City);
            }
            else
            {
                return null;
            }
        }

        public bool deleteCity(int cityId)
        {
            try
            {
                var city = uow.GetRepository<City>().Get(z => z.Id == cityId);
                uow.GetRepository<City>().Delete(city);
                uow.SaveChanges();
                return true;
                //TODO: https://www.uzmankirala.com/projeler/goster/37840/web_sayfamiza_uyelik_kayit_ve_davet_sistemi SMS 
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<CityDTO> getAllCities()
        {
            var articleList = uow.GetRepository<City>().GetAll().ToList();
            return mapper.Map<List<CityDTO>>(articleList);
        }

        public CityDTO getCity(int cityId)
        {
            var city = uow.GetRepository<City>().Get(z => z.Id == cityId);
            return mapper.Map<CityDTO>(city);
        }

        public List<CityDTO> getCityName(string cityName)
        {
            var cityList = uow.GetRepository<City>().Get(z => z.Name.Contains(cityName), null).ToList();
            return mapper.Map<List<CityDTO>>(cityList);
        }

        public CityDTO updateCity(CityDTO city)
        {
            var upCity = uow.GetRepository<City>().Get(z => z.Id == city.Id);
            upCity = mapper.Map<City>(city);
            uow.GetRepository<City>().Update(upCity);
            uow.SaveChanges();
            return mapper.Map<CityDTO>(upCity);
        }
    }
}
