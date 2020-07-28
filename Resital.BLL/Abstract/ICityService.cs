using Resital.Core.Services;
using Resital.DTO;
using System;
using System.Collections.Generic;

namespace Resital.BLL.Abstract
{
    public interface ICityService : IServiceBase
    {
        List<CityDTO> getAllCities();

        CityDTO getCity(Guid cityId);

        CityDTO addCity(CityDTO city);

        CityDTO updateCity(CityDTO city);

        bool deleteCity(Guid cityId);
    }
}