using Resital.Core.Services;
using Resital.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Resital.BLL.Abstract
{
    public interface IGuideService : IServiceBase
    {
        List<GuideDTO> getAllGuides();
        GuideDTO getGuide(int guideId);
        List<GuideDTO> getGuideName(string guideName);
        GuideDTO addGuide(GuideDTO guide);
        GuideDTO updateGuide(GuideDTO guide);
        bool deleteGuide(int guideId);
    }
}
