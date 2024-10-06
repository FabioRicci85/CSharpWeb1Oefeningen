using Microsoft.AspNetCore.Mvc;
using WebAppMVCClientLocationEFCore.Data;
using WebAppMVCClientLocationEFCore.Models;

namespace WebAppMVCClientLocationEFCore.Controllers
{
    public class ClientController : Controller
    {
        ClientLocationContext _context;
        public ClientController(ClientLocationContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }

        public IActionResult Index()
        {
            var client = _context.Clients;
            return View(client);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var client = new Client();
            return View(client);
        }

        [HttpPost]
        public IActionResult Create(Client client)
        {
            if (ModelState.IsValid)
            {
                AddClient(client);
                return RedirectToAction("Index");
            }
            return View();
        }

        private void AddClient(Client client)
        {
            _context.Clients.Add(client);
            _context.SaveChanges();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var client = _context.Clients.Where(x => x.ClientId == id).FirstOrDefault();
            return View(client);
        }

        [HttpPost]
        public IActionResult DeletePost(int id)
        {
            var client = _context.Clients.Where(x => x.ClientId == id).FirstOrDefault();
            _context.Clients.Remove(client);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var client = _context.Clients.Where(x => x.ClientId == id).FirstOrDefault();
            return View(client);
        }

        [HttpPost]
        public IActionResult Edit(Client client)
        {
            if (ModelState.IsValid)
            {
                UpdateClient(client);
                return RedirectToAction("Index");
            }
            return View(client);
        }

        private void UpdateClient(Client client)
        {
            _context.Clients.Update(client);
            _context.SaveChanges();
        }

        public IActionResult Details(int id)
        {
            var client = _context.Clients.Where(x => x.ClientId == id).FirstOrDefault();
            return View(client);
        }
    }
}
