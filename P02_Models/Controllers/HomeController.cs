﻿using Microsoft.AspNetCore.Mvc;
using P02_Models.Models;
using System.Diagnostics;

namespace P02_Models.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public JsonResult GetStudentDetail(int id)
        {
            StudentRepository repository = new StudentRepository();

            Student studentDetails = repository.Get(id);

            return Json(studentDetails); // yukardaki fonksiyondan gelen bilgiyi Json formatında bana gösterecek..geri döndürecek
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
