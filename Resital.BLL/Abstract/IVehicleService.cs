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
        VehicleDTO getVehicle(int VehicleId);
        List<VehicleDTO> getVehicleName(string VehicleName);
        VehicleDTO addVehicle(VehicleDTO Vehicle);
        VehicleDTO updateVehicle(VehicleDTO Vehicle);
        bool deleteVehicle(int VehicleId);
    }
}
