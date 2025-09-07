using goldenoutfitApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace goldenoutfitApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult SecurityUniforms()
        {
            return View();
        }
        public IActionResult HotelsUniforms()
        {
            return View();
        }
        public IActionResult HospitalsUniforms()
        {
            return View();
        }
        public IActionResult SchoolUniforms()
        {
            return View();
        }
        public IActionResult SaloonUniforms()
        {
            return View();
        }
        public IActionResult OfficeStaffUniforms()
        {
            return View();
        }
        public IActionResult Printing()
        {
            return View();
        }
        public IActionResult Fabric()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }
        public IActionResult AboutUs()
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
