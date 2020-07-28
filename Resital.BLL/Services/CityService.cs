﻿using AutoMapper;
using Resital.BLL.Abstract;
using Resital.Core.Data.UnitOfWork;
using Resital.DTO;
using Resital.Model;
using System;
using System.Collections.Generic;
using System.Linq;

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
                var city = _mapper.Map<City>(cityDto);
                _uow.GetRepository<City>().Insert(city);
                _uow.SaveChanges();
                return _mapper.Map<CityDTO>(city);
            }
            else
            {
                return null;
            }
        }

        public bool deleteCity(Guid cityId)
        {
            try
            {
                var city = _uow.GetRepository<City>().GetById(cityId);
                _uow.GetRepository<City>().Delete(city.Id);
                _uow.SaveChanges();
                return true;
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

        public CityDTO getCity(Guid cityId)
        {
            var city = _uow.GetRepository<City>().GetById(cityId);
            return _mapper.Map<CityDTO>(city);
        }

        public CityDTO updateCity(CityDTO city)
        {
            var upCity = _uow.GetRepository<City>().GetById(city.Id);
            upCity = _mapper.Map<City>(city);
            _uow.GetRepository<City>().Update(upCity);
            _uow.SaveChanges();
            return _mapper.Map<CityDTO>(upCity);
        }
    }
}