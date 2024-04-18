using Microsoft.AspNetCore.Mvc;

namespace P01_MVCBasics.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello MVC World");
        }
    }
}
