using Resital.Core.Services;
using Resital.DTO;
using System;
using System.Collections.Generic;

namespace Resital.BLL.Abstract
{
    public interface IVehicleService : IServiceBase
    {
        List<VehicleDTO> getAllVehicles();

        VehicleDTO getVehicle(Guid vehicleId);

        VehicleDTO addVehicle(VehicleDTO vehicle);

        VehicleDTO updateVehicle(VehicleDTO vehicle);

        bool deleteVehicle(Guid vehicleId);
    }
}