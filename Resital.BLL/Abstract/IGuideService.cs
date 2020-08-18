using System;
using System.Collections.Generic;
using Resital.Core.Services;
using Resital.DTO;

namespace Resital.BLL.Abstract
{
    public interface IGuideService : IServiceBase
    {
        List<GuideDto> getAllGuides();

        GuideDto getGuide(Guid guideId);

        GuideDto addGuide(GuideDto guide);

        GuideDto updateGuide(GuideDto guide);

        bool deleteGuide(Guid guideId);
    }
}