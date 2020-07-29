using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Resital.BLL.Abstract;

namespace Resital.WebUI.Controllers
{
    public class AdminController : Controller
    {
        private readonly ICompanyService _companyService;
        private readonly IRoomService _roomService;
        private readonly IVehicleService _vehicleService;

        public AdminController(ICompanyService companyService, IRoomService roomService, IVehicleService vehicleService)
        {
            _companyService = companyService;
            _roomService = roomService;
            _vehicleService = vehicleService;
        }
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

        // GET: AdminController/Details/5
        public ActionResult CompanyDetails(int id)
        {
            return View();
        }

        // GET: AdminController/Create
        public ActionResult CompanyCreate()
        {
            return View();
        }

        // POST: AdminController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CompanyCreate(IFormCollection collection)
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
        public ActionResult CompanyEdit(int id)
        {
            return View();
        }

        // POST: AdminController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CompanyEdit(int id, IFormCollection collection)
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
        public ActionResult CompanyDelete(int id)
        {
            return View();
        }

        // POST: AdminController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CompanyDelete(int id, IFormCollection collection)
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

        #endregion

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

        // GET: AdminController/Create
        public ActionResult RoomCreate()
        {
            return View();
        }

        // POST: AdminController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RoomCreate(IFormCollection collection)
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

        #endregion

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

        #endregion

    }
}
