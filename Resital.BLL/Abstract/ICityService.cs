using Resital.Core.Services;
using Resital.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Resital.BLL.Abstract
{
    public interface ICityService : IServiceBase
    {
        List<CityDTO> getAllCities();
        CityDTO getCity(int cityId);
        List<CityDTO> getCityName(string cityName);
        CityDTO addCity(CityDTO city);
        CityDTO updateCity(CityDTO city);
        bool deleteCity(int cityId);
    }
}
