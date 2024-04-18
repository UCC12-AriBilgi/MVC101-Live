using Microsoft.AspNetCore.Mvc;
using P01_MVCBasics.Models;
using System.Diagnostics;

namespace P01_MVCBasics.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(); // İlgili view ımı göster
        }

        public IActionResult Privacy()
        {
            return View(); // ilgili view Home/Privacy.html
        }

        public IActionResult Contact()
        {
            return View(); // Home/Contact
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
