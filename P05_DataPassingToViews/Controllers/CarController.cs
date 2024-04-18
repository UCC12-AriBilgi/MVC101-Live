using Microsoft.AspNetCore.Mvc;
using P05_DataPassingToViews.Models;

namespace P05_DataPassingToViews.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            List<Cars> carlist = new List<Cars>();

            carlist.Add(new Cars() { CarID = 1, BrandName = "Volvo", Family = "XC70", Year=1995 });
            carlist.Add(new Cars() { CarID = 2, BrandName = "Volkswagen", Family = "Beetle 1974", Year = 1974 });
            carlist.Add(new Cars() { CarID = 3, BrandName = "Bugatti", Family = "Chiron", Year = 2015 });
            carlist.Add(new Cars() { CarID = 4, BrandName = "Ferrari", Family = "California", Year = 2022 });
            carlist.Add(new Cars() { CarID = 1, BrandName = "Dodge", Family = "Charger SRT 8", Year = 1970 });

            ViewBag.Message = "Bu da ViewData ile taşınan bir veridir..";

            //ViewData["Author"] = authorlist;


            return View(carlist);
        }
    }
}
