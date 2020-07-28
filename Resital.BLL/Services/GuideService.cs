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
                _uow.GetRepository<Guide>().Insert(guide);
                _uow.SaveChanges();
                return _mapper.Map<GuideDTO>(guide);
            }
            else
            {
                return null;
            }
        }

        public bool deleteGuide(Guid guideId)
        {
            try
            {
                var room = _uow.GetRepository<Guide>().GetById(guideId);
                _uow.GetRepository<RoomLocation>().Delete(room.Id);
                _uow.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<GuideDTO> getAllGuides()
        {
            return _mapper.Map<List<GuideDTO>>(_uow.GetRepository<Guide>().GetAll().ToList());
        }

        public GuideDTO getGuide(Guid guideId)
        {
            var city = _uow.GetRepository<Guide>().GetById(guideId);
            return _mapper.Map<GuideDTO>(city);
        }

        public GuideDTO updateGuide(GuideDTO guide)
        {
            var upCity = _uow.GetRepository<Guide>().GetById(guide.Id);
            upCity = _mapper.Map<Guide>(guide);
            _uow.GetRepository<Guide>().Update(upCity);
            _uow.SaveChanges();
            return _mapper.Map<GuideDTO>(upCity);
        }
    }
}