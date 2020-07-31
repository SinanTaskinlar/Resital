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
            CreateMap<City, CityDto>();
            CreateMap<Company, CompanyDto>();
            CreateMap<CompanyRoute, CompanyRouteDto>();
            CreateMap<CompanyType, CompanyTypeDto>();
            CreateMap<Guide, GuideDto>();
            CreateMap<Room, RoomDto>();
            CreateMap<RoomLocation, RoomLocationDto>();
            CreateMap<RoomType, RoomTypeDto>();
            CreateMap<Route, RouteDto>();
            CreateMap<Vehicle, VehicleDto>();
            CreateMap<VehicleType, VehicleTypeDto>();

            //dtotoentity
            CreateMap<CityDto, City>();
            CreateMap<CompanyDto, Company>();
            CreateMap<CompanyRouteDto, CompanyRoute>();
            CreateMap<CompanyTypeDto, CompanyType>();
            CreateMap<GuideDto, Guide>();
            CreateMap<RoomDto, Room>();
            CreateMap<RoomLocationDto, RoomLocation>();
            CreateMap<RoomTypeDto, RoomType>();
            CreateMap<RouteDto, Route>();
            CreateMap<VehicleDto, Vehicle>();
            CreateMap<VehicleTypeDto, VehicleType>();
        }
    }
}