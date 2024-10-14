using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Query.Internal;
using MVCFifa.Data;
using MVCFifa.Models;
using MVCFifa.ViewModel;

namespace MVCFifa.Controllers
{
    public class PlayerController : Controller
    {
        ApplicationDbContext _context;
        private IWebHostEnvironment _environment;
        public PlayerController(ApplicationDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            //_context.Database.EnsureCreated();
            _environment = environment;
        }

        public IActionResult Index()
        {
            var players = _context.Players;
            return View(players);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var player = new Player();
            return View(player);
        }

        [HttpPost]
        public IActionResult Create(Player player)
        {
            if (ModelState.IsValid)
            {
                AddPlayer(player);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Create2()
        {
            var newPlayer = new NewPlayer();
            ViewData["TeamId"] = new SelectList(_context.Teams, "TeamId", "TeamName");
            return View(newPlayer);
        }

        [HttpPost]
        public IActionResult Create2(NewPlayer newPlayer)
        {
            if (ModelState.IsValid)
            {
                AddPlayer2(newPlayer);
                return RedirectToAction("Index");
            }
            return View();
        }

        private void AddPlayer2(NewPlayer newPlayer)
        {
            

        }

        private void AddPlayer(Player player) 
        { 
            _context.Players.Add(player);
            _context.SaveChanges();
        }

        public IActionResult Details(int id)
        {
            var player = _context.Players.Where(x => x.PlayerId == id).FirstOrDefault();
            var fileExist = false;
            if(player.ImageLink != null)
            {
                var path = _environment.WebRootPath;
                var file = Path.Combine($"{path}\\images", player.ImageLink);
                fileExist = System.IO.File.Exists(file);
            }
            ViewBag.FileExist = fileExist;
            return View(player);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var player = _context.Players.Where(x => x.PlayerId == id).FirstOrDefault();
            return View(player);
        }

        [HttpPost]
        public IActionResult DeletePost(int id)
        {
            var player = _context.Players.Where(x => x.PlayerId == id).FirstOrDefault();
            _context.Players.Remove(player);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var player = _context.Players.Where(x => x.PlayerId == id).FirstOrDefault();
            return View(player);
        }

        [HttpPost]
        public IActionResult Edit(Player player)
        {
            if (ModelState.IsValid)
            {
                UpdatePlayer(player);
                return RedirectToAction("Index");
            }
            return View(player);
        }

        private void UpdatePlayer(Player player)
        {
            _context.Players.Update(player);
            _context.SaveChanges();
        }
    }
}
