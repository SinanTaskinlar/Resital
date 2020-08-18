using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Resital.BLL.Abstract;
using Resital.Core.Data.UnitOfWork;
using Resital.DTO;
using Resital.Model;

namespace Resital.BLL.Services
{
    public class GuideService : IGuideService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public GuideService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public GuideDto addGuide(GuideDto guideDto)
        {
            if (!_uow.GetRepository<Guide>().GetAll().Any(z => z.Name == guideDto.Name))
            {
                var guide = _mapper.Map<Guide>(guideDto);
                _uow.GetRepository<Guide>().Insert(guide);
                _uow.SaveChanges();
                return _mapper.Map<GuideDto>(guide);
            }

            return null;
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

        public List<GuideDto> getAllGuides()
        {
            return _mapper.Map<List<GuideDto>>(_uow.GetRepository<Guide>().GetAll().ToList());
        }

        public GuideDto getGuide(Guid guideId)
        {
            var city = _uow.GetRepository<Guide>().GetById(guideId);
            return _mapper.Map<GuideDto>(city);
        }

        public GuideDto updateGuide(GuideDto guide)
        {
            var upCity = _uow.GetRepository<Guide>().GetById(guide.Id);
            upCity = _mapper.Map<Guide>(guide);
            _uow.GetRepository<Guide>().Update(upCity);
            _uow.SaveChanges();
            return _mapper.Map<GuideDto>(upCity);
        }
    }
}