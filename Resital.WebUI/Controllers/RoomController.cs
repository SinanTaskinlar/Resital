using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Resital.BLL.Abstract;
using Resital.WebUI.Controllers;

namespace Web.Controllers
{
    public class RoomController : Controller
    {
        private readonly ILogger<CompanyController> _logger;
        private readonly ICompanyService _companyService;
        private readonly IRoomService _roomService;
        private readonly IRoomLocationService _roomLocationService;
        private readonly IRoomTypeService _roomTypeService;

        public RoomController(ILogger<CompanyController> logger, 
            ICompanyService companyService, 
            IRoomService roomService,
            IRoomTypeService roomTypeService,
            IRoomLocationService roomLocationService)
        {
            _logger = logger;
            _companyService = companyService;
            _roomService = roomService;
            _roomTypeService = roomTypeService;
            _roomLocationService = roomLocationService;

        }

        public IActionResult Index()
        {
            var a = _roomService.getAllRooms();
            return View(a);
        }

        [HttpPost]
        public IActionResult Index(string name)
        {
            var a = _companyService.getAllCompanies().FirstOrDefault(z => z.Name == name);

            if (a != null)
            {
                var rooms = _roomService.getAllRooms().Where(z => z.Company.Id == a.Id).ToList();
                //foreach (var room in rooms)
                //{
                //    room.Company.Name = _companyService.getCompany(room.CompanyId).Name;
                //    room.RoomLocation.Name = _roomLocationService.getRoomLocation(room.RoomLocationId).Name;
                //    room.RoomType.Name = _roomTypeService.getRoomType(room.RoomTypeId).Name;
                //}
                return View(rooms);
            }
            return View(_roomService.getAllRooms());
        }
    }
}