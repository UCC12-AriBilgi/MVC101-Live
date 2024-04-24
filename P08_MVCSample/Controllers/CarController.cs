using Microsoft.AspNetCore.Mvc;
using P08_MVCSample.Data;
using P08_MVCSample.Models;

namespace P08_MVCSample.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Listele()
        {
            return View(CarData.Cars); // CarData içersinde varolan bilgiyi Listele View ına taşı
        }

        // GET
        public IActionResult Create()
        {
            return View(); // CarData içersinde yeni bir kayıt oluşturmak için Create View ına git
        }

        [HttpPost]
        public IActionResult Create(Car newcar)
        {
            // Burası View tarafından gönderilen verilerin işleneceği bölüm

            CarData.Cars.Add(newcar);
            return RedirectToAction("Listele");
        }


        public IActionResult Details(int id)
        {
            // Burası View tarafından gönderilen id nin detaylarının gösterileceği view

            var car = CarData.Cars.Where(c=>c.CarID == id).FirstOrDefault();

            return View(car);
        }

        // GET
        public IActionResult Edit(int id)
        {
            // Burası View tarafından gönderilen id ye göre ilgili kaydı üzerinde değişiklik yapılabilecek şekilde view tarafında gösterecek

            var car = CarData.Cars.Where(c => c.CarID == id).FirstOrDefault();

            return View(car);
        }

        //POST
        [HttpPost]
        public IActionResult Edit(Car car) // View tarafından gelen
        {
            // Burası View tarafından gönderilen id ye göre ilgili kaydı üzerinde değişiklik yapılabilecek şekilde view tarafında gösterecek

            Car editcar = CarData.Cars.Where(c=> c.CarID==car.CarID).FirstOrDefault();

            // Yeni bilgiler atanıyor.
            editcar.CarID= car.CarID;
            editcar.BrandName=car.BrandName;
            editcar.Family=car.Family;
            editcar.Year=car.Year;

            return RedirectToAction("Listele");



            return View(car);
        }

    }
}
