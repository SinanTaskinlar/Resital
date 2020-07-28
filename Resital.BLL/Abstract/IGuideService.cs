using Resital.Core.Services;
using Resital.DTO;
using System;
using System.Collections.Generic;

namespace Resital.BLL.Abstract
{
    public interface IGuideService : IServiceBase
    {
        List<GuideDTO> getAllGuides();

        GuideDTO getGuide(Guid guideId);

        GuideDTO addGuide(GuideDTO guide);

        GuideDTO updateGuide(GuideDTO guide);

        bool deleteGuide(Guid guideId);
    }
}