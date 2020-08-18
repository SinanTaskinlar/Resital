using System;
using System.Collections.Generic;
using Resital.Core.Services;
using Resital.DTO;

namespace Resital.BLL.Abstract
{
    public interface ICityService : IServiceBase
    {
        List<CityDto> getAllCities();

        CityDto getCity(Guid cityId);

        CityDto addCity(CityDto city);

        CityDto updateCity(CityDto city);

        bool deleteCity(Guid cityId);
    }
}