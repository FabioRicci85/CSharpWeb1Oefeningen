using Microsoft.AspNetCore.Mvc;

namespace MVCTestEFCore.Controllers
{
    public class FirstTableController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
