using Resital.Core.Services;
using Resital.DTO;
using System;
using System.Collections.Generic;

namespace Resital.BLL.Abstract
{
    public interface IVehicleService : IServiceBase
    {
        List<VehicleDto> getAllVehicles();

        VehicleDto getVehicle(Guid vehicleId);

        VehicleDto addVehicle(VehicleDto vehicle);

        VehicleDto updateVehicle(VehicleDto vehicle);

        bool deleteVehicle(Guid vehicleId);
    }
}