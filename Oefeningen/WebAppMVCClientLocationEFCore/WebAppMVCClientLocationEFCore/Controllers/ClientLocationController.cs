using Microsoft.AspNetCore.Mvc;
using WebAppMVCClientLocationEFCore.Data;
using WebAppMVCClientLocationEFCore.ViewModels;

namespace WebAppMVCClientLocationEFCore.Controllers
{
    public class ClientLocationController : Controller
    {
        ClientLocationContext _context;
        public ClientLocationController(ClientLocationContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }



        public IActionResult Index()
        {
            var clientLocation = _context.Clients.Select(x => new ClientLocation
            {
                ClientName = x.ClientName,
                City = _context.Locations.Where(y => y.LocationId == x.LocationId).FirstOrDefault().City
            });
            return View(clientLocation);
        }
    }
}
