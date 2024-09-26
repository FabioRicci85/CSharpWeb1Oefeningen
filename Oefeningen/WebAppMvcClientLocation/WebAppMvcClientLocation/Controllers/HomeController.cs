using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppMvcClientLocation.Models;

namespace WebAppMvcClientLocation.Controllers
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
            int clientCount = Data.Database.Clients.Count;
            ViewBag.ClientCount = clientCount;
            int locationCount = Data.Database.Locations.Count;
            ViewBag.LocationCount = locationCount;
            return View();
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
