using Microsoft.AspNetCore.Mvc;
using WebAppMvcClientLocation.Data;
using WebAppMvcClientLocation.Models;

namespace WebAppMvcClientLocation.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            return View(Database.Clients);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Client c)
        {
            Database.AddClient(c);
            return RedirectToAction("Index", "Client");
        }
        

        
    }
}
