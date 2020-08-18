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
    public class VehicleService : IVehicleService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public VehicleService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public List<VehicleDto> getAllVehicles()
        {
            return _mapper.Map<List<VehicleDto>>(_uow.GetRepository<Vehicle>().GetAll().ToList());
        }

        public VehicleDto getVehicle(Guid vehicleId)
        {
            var route = _uow.GetRepository<Vehicle>().GetById(vehicleId);
            return _mapper.Map<VehicleDto>(route);
        }

        public VehicleDto addVehicle(VehicleDto vehicle)
        {
            if (!_uow.GetRepository<Vehicle>().GetAll().Any(z => z.Name == vehicle.Name))
            {
                var company = _mapper.Map<Vehicle>(vehicle);
                _uow.GetRepository<Vehicle>().Insert(company);
                _uow.SaveChanges();
                return _mapper.Map<VehicleDto>(company);
            }

            return null;
        }

        public VehicleDto updateVehicle(VehicleDto vehicle)
        {
            var upCompanyRegion = _uow.GetRepository<Vehicle>().GetById(vehicle.Id);
            upCompanyRegion = _mapper.Map<Vehicle>(vehicle);
            _uow.GetRepository<Vehicle>().Update(upCompanyRegion);
            _uow.SaveChanges();
            return _mapper.Map<VehicleDto>(upCompanyRegion);
        }

        public bool deleteVehicle(Guid vehicleId)
        {
            try
            {
                var company = _uow.GetRepository<Vehicle>().GetById(vehicleId);
                _uow.GetRepository<Vehicle>().Delete(company.Id);
                _uow.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}