using Microsoft.AspNetCore.Mvc;
using WebAppMVCClientLocationEFCore.Data;
using WebAppMVCClientLocationEFCore.Models;

namespace WebAppMVCClientLocationEFCore.Controllers
{
    public class LocationController : Controller
    {
        //dependency injection
        ClientLocationContext _context;
        public LocationController(ClientLocationContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }

        public IActionResult Index()
        {
            var location = _context.Locations;
            return View(location);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var location = new Location();
            return View(location);
        }

        [HttpPost]
        public IActionResult Create(Location location)
        {
            if(ModelState.IsValid)
            {
                AddLocation(location);
                return RedirectToAction("Index");
            }
            return View();
        }

        private void AddLocation(Location location)
        {
            _context.Locations.Add(location);
            _context.SaveChanges();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var location = _context.Locations.Where(x => x.LocationId == id).FirstOrDefault();
            return View(location);
        }

        [HttpPost]
        public IActionResult DeletePost(int id)
        {
            var location = _context.Locations.Where(x => x.LocationId == id).FirstOrDefault();

            _context.Locations.Remove(location);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var location = _context.Locations.Where(x => x.LocationId == id).FirstOrDefault();
            return View(location);
        }

        [HttpPost]
        public IActionResult Edit(Location location)
        {
            if (ModelState.IsValid)
            {
                UpdateLocation(location);
                return RedirectToAction("Index");
            }
            return View(location);
        }

        private void UpdateLocation(Location location)
        {
            _context.Locations.Update(location);
            _context.SaveChanges();
        }

        public IActionResult Details(int id)
        {
            var location = _context.Locations.Where(x => x.LocationId == id).FirstOrDefault();
            return View(location);
        }
    }
}
