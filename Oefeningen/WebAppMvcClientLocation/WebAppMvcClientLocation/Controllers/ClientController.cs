using Microsoft.AspNetCore.Mvc;

namespace WebAppMvcClientLocation.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
