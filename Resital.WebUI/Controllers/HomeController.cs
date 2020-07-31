using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Resital.WebUI.Models;
using System.Diagnostics;
using Resital.BLL.Abstract;

namespace Resital.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICityService _cityService;

        public HomeController(ICityService cityService) => _cityService = cityService;

        public IActionResult Index()
        {
            var vmAllCities = _cityService.getAllCities();
            return View(vmAllCities);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}