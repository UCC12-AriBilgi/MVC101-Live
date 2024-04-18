using Microsoft.AspNetCore.Mvc;

namespace P03_Controllers.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // Action metotları

        public string GetAll()
        {
            return "--- Tüm Öğrenciler ---";
        }

        public string GetOneStudent(string name)
        {
            return $"Bilgisini istemiş olduğunuz öğrenci adı : {name}";
        }

        // Student/Ortalama?not1=45&not2=55&not3=40
        public string Ortalama(int not1,int not2,int not3)
        {
            int sonuc;

            sonuc = (not1 + not2 +not3);

            return $"Öğrenci not toplamı : {sonuc.ToString()}";
        }
    }
}
