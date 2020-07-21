using AutoMapper;
using Resital.BLL.Abstract;
using Resital.Core.Data.UnitOfWork;
using Resital.DTO;
using Resital.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Resital.BLL.Services
{
    public class GuideService : IGuideService
    {
        private readonly IUnitOfWork uow;
        private readonly IMapper mapper;

        public GuideService(IUnitOfWork _uow, IMapper _mapper)
        {
            uow = _uow;
            mapper = _mapper;
        }

        public GuideDTO addGuide(GuideDTO guide)
        {
            if (!uow.GetRepository<Guide>().GetAll().Any(z => z.Name == guide.Name))
            {
                Guide Guide = mapper.Map<Guide>(guide);
                uow.GetRepository<Guide>().Add(Guide);//todo: int guid
                uow.SaveChanges();
                return mapper.Map<GuideDTO>(Guide);
            }
            else
            {
                return null;
            }
        }

        public bool deleteGuide(int guideId)
        {
            try
            {
                uow.GetRepository<Guide>().Delete(uow.GetRepository<Guide>().Get(z => z.Id == guideId));
                uow.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<GuideDTO> getAllGuides()
        {
            return mapper.Map<List<GuideDTO>>(uow.GetRepository<Guide>().GetAll().ToList());
        }

        public List<GuideDTO> getGuideName(string guideName)
        {
            var cityList = uow.GetRepository<Guide>().Get(z => z.Name.Contains(guideName), null).ToList();
            return mapper.Map<List<GuideDTO>>(cityList);
        }

        public GuideDTO getGuide(int guideId)
        {
            var city = uow.GetRepository<Guide>().Get(z => z.Id == guideId);
            return mapper.Map<GuideDTO>(city);
        }

        public GuideDTO updateGuide(GuideDTO guide)
        {
            var upCity = uow.GetRepository<Guide>().Get(z => z.Id == guide.Id);
            upCity = mapper.Map<Guide>(guide);
            uow.GetRepository<Guide>().Update(upCity);
            uow.SaveChanges();
            return mapper.Map<GuideDTO>(upCity);
        }
    }
}
