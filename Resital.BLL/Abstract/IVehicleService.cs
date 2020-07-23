using Resital.Core.Services;
using Resital.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Resital.BLL.Abstract
{
    public interface IVehicleService : IServiceBase
    {
        List<VehicleDTO> getAllVehicles();
        VehicleDTO getVehicle(int vehicleId);
        List<VehicleDTO> getVehicleName(string vehicleName);
        VehicleDTO addVehicle(VehicleDTO vehicle);
        VehicleDTO updateVehicle(VehicleDTO vehicle);
        bool deleteVehicle(int vehicleId);
    }
}
