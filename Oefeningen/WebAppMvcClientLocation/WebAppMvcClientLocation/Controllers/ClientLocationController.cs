using Microsoft.AspNetCore.Mvc;
using WebAppMvcClientLocation.Models;
using WebAppMvcClientLocation.Data;

namespace WebAppMvcClientLocation.Controllers
{
    public class ClientLocationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
