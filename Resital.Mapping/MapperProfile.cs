using AutoMapper;
using Resital.DTO;
using Resital.Model;

namespace Resital.Mapping
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            //entitytodto
            CreateMap<City, CityDTO>();
            CreateMap<Company, CompanyDTO>();
            CreateMap<CompanyRoute, CompanyRouteDTO>();
            CreateMap<CompanyType, CompanyTypeDTO>();
            CreateMap<Guide, GuideDTO>();
            CreateMap<Room, RoomDTO>();
            CreateMap<RoomLocation, RoomLocationDTO>();
            CreateMap<RoomType, RoomTypeDTO>();
            CreateMap<Route, RouteDTO>();
            CreateMap<Vehicle, VehicleDTO>();
            CreateMap<VehicleType, VehicleTypeDTO>();

            //dtotoentity
            CreateMap<CityDTO, City>();
            CreateMap<CompanyDTO, Company>();
            CreateMap<CompanyRouteDTO, CompanyRoute>();
            CreateMap<CompanyTypeDTO, CompanyType>();
            CreateMap<GuideDTO, Guide>();
            CreateMap<RoomDTO, Room>();
            CreateMap<RoomLocationDTO, RoomLocation>();
            CreateMap<RoomTypeDTO, RoomType>();
            CreateMap<RouteDTO, Route>();
            CreateMap<VehicleDTO, Vehicle>();
            CreateMap<VehicleTypeDTO, VehicleType>();
        }
    }
}