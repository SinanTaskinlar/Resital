using Resital.Core.Services;
using Resital.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Resital.BLL.Abstract
{
    public interface IRegionService : IServiceBase
    {
        List<RegionDTO> getAllRegions();
        RegionDTO getRegion(int regionId);
        List<RegionDTO> getRegionName(string regionName);
        RegionDTO addRegion(RegionDTO region);
        RegionDTO updateRegion(RegionDTO region);
        bool deleteRegion(int regionId);
    }
}
