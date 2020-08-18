using System.Collections.Generic;
using Resital.Core.Services;
using Resital.DTO;

namespace Resital.BLL.Abstract
{
    public interface IVehicleTypeService : IServiceBase
    {
        List<VehicleTypeDto> getAllVehicleTypes();

        VehicleTypeDto getVehicleType(int vehicleTypeId);

        List<VehicleTypeDto> getVehicleTypeName(string vehicleTypeName);

        VehicleTypeDto addVehicleType(VehicleTypeDto vehicleType);

        VehicleTypeDto updateVehicleType(VehicleTypeDto vehicleType);

        bool deleteVehicleType(int vehicleTypeId);
    }
}