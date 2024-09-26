using Microsoft.AspNetCore.Mvc;

namespace WebAppMvcClientLocation.Controllers
{
    public class LocationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
