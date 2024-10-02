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
            if (ModelState.IsValid)
            {
                var bestaandeClientId = Database.Clients.FirstOrDefault(client => client.ClientId == c.ClientId);

                if (bestaandeClientId != null)
                {
                    ModelState.AddModelError("ClientId", "Probleem met de ClientId");
                    return View("Create", c);
                }
                Database.AddClient(c);
                return RedirectToAction("Index", "Client");
            }
            return View("Create", c);

        }



    }
}
