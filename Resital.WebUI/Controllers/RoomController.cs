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

        public RoomController(ILogger<CompanyController> logger, ICompanyService companyService, IRoomService roomService)
        {
            _logger = logger;
            _companyService = companyService;
            _roomService = roomService;
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
                var rooms = _roomService.getAllRooms().Where(z => a != null && z.CompanyId == a.Id).ToList();
                return View(rooms);
            }
            return View(_roomService.getAllRooms());
        }
    }
}
