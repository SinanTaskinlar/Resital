using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Resital.BLL.Abstract;
using Resital.DTO;
using Resital.WebUI.Models;
using System;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Resital.WebUI.Controllers
{
    public class AdminController : Controller
    {
        #region Cons

        private readonly ICompanyService _companyService;
        private readonly IRoomService _roomService;
        private readonly IVehicleService _vehicleService;
        private readonly ICompanyTypeService _companyTypeService;
        private readonly IRoomLocationService _roomLocationService;
        private readonly IRoomTypeService _roomTypeService;

        public AdminController(
            ICompanyService companyService,
            IRoomService roomService,
            IVehicleService vehicleService,
            ICompanyTypeService companyTypeService,
            IRoomLocationService roomLocationService,
            IRoomTypeService roomTypeService
            )
        {
            _companyService = companyService;
            _roomService = roomService;
            _vehicleService = vehicleService;
            _companyTypeService = companyTypeService;
            _roomLocationService = roomLocationService;
            _roomTypeService = roomTypeService;
        }

        #endregion Cons

        // GET: AdminController
        public ActionResult Index()
        {
            return View();
        }

        #region Company

        public IActionResult CompanyList()
        {
            var comp = _companyService.getAllCompanies();
            return View(comp);
        }

        // GET: Admin/CompanyDetails/5
        public ActionResult CompanyDetails(Guid Id)
        {
            var a = _companyService.getCompany(Id);
            return View(a);
        }

        // GET: Admin/CompanyCreate
        [HttpGet]
        public ActionResult CompanyCreate()
        {
            CompanyViewModel comp = new CompanyViewModel();
            var a = _companyTypeService.getAllCompanyTypes();
            return View(a);
        }

        // POST: Admin/CompanyCreate
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CompanyCreate(IFormCollection collection)
        {
            CompanyDto dto = new CompanyDto();
            dto.Name = collection["Name"];
            dto.Address = collection["Address"];
            dto.Note = collection["Note"];
            dto.CompanyTypeId = Guid.Parse(collection["CompanyTypeId"]);

            try
            {
                _companyService.addCompany(dto);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminController/CompanyEdit/5
        public ActionResult CompanyEdit(Guid id)
        {
            var a = _companyService.getCompany(id);
            return View(a);
        }

        // POST: AdminController/CompanyEdit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CompanyEdit(IFormCollection collection)
        {
            var a = _companyService.getCompany(Guid.Parse(collection["Id"]));
            a.Name = collection["Name"];
            a.Address = collection["Address"];
            a.Note = collection["Note"];
            a.CompanyTypeId = Guid.Parse(collection["CompanyTypeId"]);

            var b = _companyService.updateCompany(a);

            try
            {
                return RedirectToAction("CompanyList");
            }
            catch
            {
                return View();
            }
        }

        // POST: AdminController/CompanyDelete/GUID
        [HttpPost]
        public IActionResult CompanyDelete(Guid Id)
        {
            try
            {
                var a = _companyService.deleteCompany(Id);
                Console.WriteLine(a);
                return RedirectToAction("CompanyList");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return RedirectToAction("CompanyList");
            }
        }

        #endregion Company

        #region Room

        public IActionResult RoomList()
        {
            var rooms = _roomService.getAllRooms();
            return View(rooms);
        }

        // GET: AdminController/Details/5
        public ActionResult RoomDetails(int id)
        {
            return View();
        }

        // GET: AdminController/RoomCreate
        public ActionResult RoomCreate()
        {
            RoomViewModel a = new RoomViewModel();
            a.Companies = _companyService.getAllCompanies();
            a.Locations = _roomLocationService.getAllRoomLocations();
            a.Types = _roomTypeService.getAllRoomTypes();
            return View(a);
        }

        // POST: AdminController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RoomCreate(IFormCollection collection)
        {
            RoomDto dto = new RoomDto
            {
                CompanyId = Guid.Parse(collection["Comp"]),
                RoomLocationId = Guid.Parse(collection["Loc"]),
                RoomTypeId = Guid.Parse(collection["Type"])
            };
            try
            {
                _roomService.addRoom(dto);
                return RedirectToAction("RoomList");
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminController/Edit/5
        public ActionResult RoomEdit(int id)
        {
            return View();
        }

        // POST: AdminController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RoomEdit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminController/Delete/5
        public ActionResult RoomDelete(int id)
        {
            return View();
        }

        // POST: AdminController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RoomDelete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        #endregion Room

        #region Vehicle

        public IActionResult VehicleList()
        {
            var vehicles = _vehicleService.getAllVehicles();
            return View(vehicles);
        }

        // GET: AdminController/Details/5
        public ActionResult VehicleDetails(int id)
        {
            return View();
        }

        // GET: AdminController/Create
        public ActionResult VehicleCreate()
        {
            return View();
        }

        // POST: AdminController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult VehicleCreate(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminController/Edit/5
        public ActionResult VehicleEdit(int id)
        {
            return View();
        }

        // POST: AdminController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult VehicleEdit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminController/Delete/5
        public ActionResult VehicleDelete(int id)
        {
            return View();
        }

        // POST: AdminController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult VehicleDelete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        #endregion Vehicle
    }
}