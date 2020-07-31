using Resital.Core.Services;
using Resital.DTO;
using System;
using System.Collections.Generic;

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