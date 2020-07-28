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
    public class RegionService : IRegionService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public RegionService(IUnitOfWork uow, IMapper mapper)
        {
            this._mapper = mapper;
            this._uow = uow;
        }

        public List<RegionDTO> getAllRegions()
        {
            return _mapper.Map<List<RegionDTO>>(_uow.GetRepository<Region>().GetAll().ToList());
        }

        public RegionDTO getRegion(Guid regionId)
        {
            var region = _uow.GetRepository<Region>().GetById(regionId);
            return _mapper.Map<RegionDTO>(region);
        }

        public RegionDTO addRegion(RegionDTO regionDto)
        {
            if (!_uow.GetRepository<Region>().GetAll().Any(z => z.Name == regionDto.Name))
            {
                var region = _mapper.Map<Region>(regionDto);
                _uow.GetRepository<Region>().Insert(region);
                _uow.SaveChanges();
                return _mapper.Map<RegionDTO>(region);
            }
            else
            {
                return null;
            }
        }

        public RegionDTO updateRegion(RegionDTO regionDto)
        {
            var upCity = _uow.GetRepository<Region>().GetById(regionDto.Id);
            upCity = _mapper.Map<Region>(regionDto);
            _uow.GetRepository<Region>().Update(upCity);
            _uow.SaveChanges();
            return _mapper.Map<RegionDTO>(upCity);
        }

        public bool deleteRegion(Guid regionId)
        {
            try
            {
                var region = _uow.GetRepository<Region>().GetById(regionId);
                _uow.GetRepository<Region>().Delete(region.Id);
                _uow.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}