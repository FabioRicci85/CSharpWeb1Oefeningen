using Microsoft.AspNetCore.Mvc;

namespace WebAppMvcClientLocation.Controllers
{
    public class OverviewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
