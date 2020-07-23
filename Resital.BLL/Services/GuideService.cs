using AutoMapper;
using Resital.BLL.Abstract;
using Resital.Core.Data.UnitOfWork;
using Resital.DTO;
using Resital.Model;
using System.Collections.Generic;
using System.Linq;

namespace Resital.BLL.Services
{
    public class GuideService : IGuideService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public GuideService(IUnitOfWork uow, IMapper mapper)
        {
            this._uow = uow;
            this._mapper = mapper;
        }

        public GuideDTO addGuide(GuideDTO guideDto)
        {
            if (!_uow.GetRepository<Guide>().GetAll().Any(z => z.Name == guideDto.Name))
            {
                var guide = _mapper.Map<Guide>(guideDto);
                _uow.GetRepository<Guide>().Add(guide);
                _uow.SaveChanges();
                return _mapper.Map<GuideDTO>(guide);
            }
            else
                return null;
        }

        public bool deleteGuide(int guideId)
        {
                _uow.GetRepository<Guide>().Delete(_uow.GetRepository<Guide>().Get(z => z.Id == guideId));
                _uow.SaveChanges();
                return true;
        }

        public List<GuideDTO> getAllGuides()
        {
            return _mapper.Map<List<GuideDTO>>(_uow.GetRepository<Guide>().GetAll().ToList());
        }

        public List<GuideDTO> getGuideName(string guideName)
        {
            var cityList = _uow.GetRepository<Guide>().Get(z => z.Name.Contains(guideName), null).ToList();
            return _mapper.Map<List<GuideDTO>>(cityList);
        }

        public GuideDTO getGuide(int guideId)
        {
            var city = _uow.GetRepository<Guide>().Get(z => z.Id == guideId);
            return _mapper.Map<GuideDTO>(city);
        }

        public GuideDTO updateGuide(GuideDTO guide)
        {
            var upCity = _uow.GetRepository<Guide>().Get(z => z.Id == guide.Id);
            upCity = _mapper.Map<Guide>(guide);
            _uow.GetRepository<Guide>().Update(upCity);
            _uow.SaveChanges();
            return _mapper.Map<GuideDTO>(upCity);
        }
    }
}
