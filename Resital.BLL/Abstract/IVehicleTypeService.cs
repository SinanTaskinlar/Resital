using Resital.Core.Services;
using Resital.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Resital.BLL.Abstract
{
    public interface IVehicleTypeService : IServiceBase
    {
        List<VehicleTypeDTO> getAllVehicleTypes();
        VehicleTypeDTO getVehicleType(int VehicleTypeId);
        List<VehicleTypeDTO> getVehicleTypeName(string VehicleTypeName);
        VehicleTypeDTO addVehicleType(VehicleTypeDTO VehicleType);
        VehicleTypeDTO updateVehicleType(VehicleTypeDTO VehicleType);
        bool deleteVehicleType(int VehicleTypeId);
    }
}
