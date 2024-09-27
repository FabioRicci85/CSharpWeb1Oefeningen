using Microsoft.AspNetCore.Mvc;
using WebAppMvcClientLocation.Data;
using WebAppMvcClientLocation.Models;

namespace WebAppMvcClientLocation.Controllers
{
    public class LocationsController : Controller
    {
        public IActionResult Index()
        {
            return View(Database.Locations);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Location l)
        {
            Database.AddLocation(l);
            return RedirectToAction("Index", "Location");
        }
        
    }
}
