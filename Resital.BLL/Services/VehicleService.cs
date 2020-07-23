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

        public VehicleDTO getVehicle(int vehicleId)
        {
            var route = _uow.GetRepository<Vehicle>().Get(z => z.Id == vehicleId);
            return _mapper.Map<VehicleDTO>(route);
        }

        public List<VehicleDTO> getVehicleName(string vehicleName)
        {
            var cityList = _uow.GetRepository<Vehicle>().Get(z => z.Name.Contains(vehicleName), null).ToList();
            return _mapper.Map<List<VehicleDTO>>(cityList);
        }

        public VehicleDTO addVehicle(VehicleDTO vehicle)
        {
            if (!_uow.GetRepository<Vehicle>().GetAll().Any(z => z.Name == vehicle.Name))
            {
                var company = _mapper.Map<Vehicle>(vehicle);
                _uow.GetRepository<Vehicle>().Add(company);
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
            var upCompanyRegion = _uow.GetRepository<Vehicle>().Get(z => z.Id == vehicle.Id);
            upCompanyRegion = _mapper.Map<Vehicle>(vehicle);
            _uow.GetRepository<Vehicle>().Update(upCompanyRegion);
            _uow.SaveChanges();
            return _mapper.Map<VehicleDTO>(upCompanyRegion);
        }

        public bool deleteVehicle(int vehicleId)
        {
            if (vehicleId <= 0) throw new ArgumentOutOfRangeException(nameof(vehicleId));
            try
            {
                var Company = _uow.GetRepository<Vehicle>().Get(z => z.Id == vehicleId);
                _uow.GetRepository<Vehicle>().Delete(Company);
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