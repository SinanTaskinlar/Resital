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
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public CityService(IUnitOfWork uow, IMapper mapper)
        {
            this._uow = uow;
            this._mapper = mapper;
        }

        public CityDTO addCity(CityDTO cityDto)
        {
            if (!_uow.GetRepository<City>().GetAll().Any(z => z.Name == cityDto.Name))
            {
                City city = _mapper.Map<City>(cityDto);
                _uow.GetRepository<City>().Add(city);
                _uow.SaveChanges();
                return _mapper.Map<CityDTO>(city);
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
                var city = _uow.GetRepository<City>().Get(z => z.Id == cityId);
                _uow.GetRepository<City>().Delete(city);
                _uow.SaveChanges();
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
            var articleList = _uow.GetRepository<City>().GetAll().ToList();
            return _mapper.Map<List<CityDTO>>(articleList);
        }

        public CityDTO getCity(int cityId)
        {
            var city = _uow.GetRepository<City>().Get(z => z.Id == cityId);
            return _mapper.Map<CityDTO>(city);
        }

        public List<CityDTO> getCityName(string cityName)
        {
            var cityList = _uow.GetRepository<City>().Get(z => z.Name.Contains(cityName), null).ToList();
            return _mapper.Map<List<CityDTO>>(cityList);
        }

        public CityDTO updateCity(CityDTO city)
        {
            var upCity = _uow.GetRepository<City>().Get(z => z.Id == city.Id);
            upCity = _mapper.Map<City>(city);
            _uow.GetRepository<City>().Update(upCity);
            _uow.SaveChanges();
            return _mapper.Map<CityDTO>(upCity);
        }
    }
}
