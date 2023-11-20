using Microsoft.AspNetCore.Mvc;
using WebApplication3.DAL;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
