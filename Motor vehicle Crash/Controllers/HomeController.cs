using Microsoft.AspNetCore.Mvc;
using Motor_vehicle_Crash.Models;
using System.Diagnostics;

namespace Motor_vehicle_Crash.Controllers
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

        public IActionResult Charts()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
