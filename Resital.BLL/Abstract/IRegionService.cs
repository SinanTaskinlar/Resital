using Resital.Core.Services;
using Resital.DTO;
using System;
using System.Collections.Generic;

namespace Resital.BLL.Abstract
{
    public interface IRegionService : IServiceBase
    {
        List<RegionDTO> getAllRegions();

        RegionDTO getRegion(Guid regionId);

        RegionDTO addRegion(RegionDTO region);

        RegionDTO updateRegion(RegionDTO region);

        bool deleteRegion(Guid regionId);
    }
}