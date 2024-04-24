using Microsoft.AspNetCore.Mvc;
using P08_MVCSample.Data;

namespace P08_MVCSample.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Listele()
        {
            return View(CarData.Cars);
        }
    }
}
