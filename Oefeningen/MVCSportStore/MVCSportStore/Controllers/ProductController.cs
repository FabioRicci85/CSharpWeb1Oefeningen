using Microsoft.AspNetCore.Mvc;
using MVCSportStore.Data;
using MVCSportStore.Models;
using MVCSportStore.ViewModels;

namespace MVCSportStore.Controllers
{
    public class ProductController : Controller
    {
        private StoreDbContext _context;
        public ProductController(StoreDbContext context)
        {
            _context = context;            
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product) 
        {
            if (ModelState.IsValid) 
            {
                AddProducts(product);
                return RedirectToAction("Index", "Home");
            }
            return View(product);
        }

        private void AddProducts(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }


    }
}
