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
    public class VehicleService : IVehicleService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public VehicleService(IUnitOfWork uow, IMapper mapper)
        {
            this._uow = uow;
            this._mapper = mapper;
        }

        public List<VehicleDTO> getAllVehicles()
        {
            return _mapper.Map<List<VehicleDTO>>(_uow.GetRepository<Vehicle>().GetAll().ToList());
        }

        public VehicleDTO getVehicle(Guid vehicleId)
        {
            var route = _uow.GetRepository<Vehicle>().GetById(vehicleId);
            return _mapper.Map<VehicleDTO>(route);
        }

        public VehicleDTO addVehicle(VehicleDTO vehicle)
        {
            if (!_uow.GetRepository<Vehicle>().GetAll().Any(z => z.Name == vehicle.Name))
            {
                var company = _mapper.Map<Vehicle>(vehicle);
                _uow.GetRepository<Vehicle>().Insert(company);
                _uow.SaveChanges();
                return _mapper.Map<VehicleDTO>(company);
            }
            else
            {
                return null;
            }
        }

        public VehicleDTO updateVehicle(VehicleDTO vehicle)
        {
            var upCompanyRegion = _uow.GetRepository<Vehicle>().GetById(vehicle.Id);
            upCompanyRegion = _mapper.Map<Vehicle>(vehicle);
            _uow.GetRepository<Vehicle>().Update(upCompanyRegion);
            _uow.SaveChanges();
            return _mapper.Map<VehicleDTO>(upCompanyRegion);
        }

        public bool deleteVehicle(Guid vehicleId)
        {
            try
            {
                var Company = _uow.GetRepository<Vehicle>().GetById(vehicleId);
                _uow.GetRepository<Vehicle>().Delete(Company.Id);
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