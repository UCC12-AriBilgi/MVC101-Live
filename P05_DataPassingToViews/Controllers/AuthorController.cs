using Microsoft.AspNetCore.Mvc;
using P05_DataPassingToViews.Models;

namespace P05_DataPassingToViews.Controllers
{
    public class AuthorController : Controller
    {


        public IActionResult Index()
        { 
            // Veri taşıma yöntemleri
                 // - ViewBag
                 // Controller --> View a giderken veri tasımak için kulllanılıyor. Tersi bir durum View --> Controller tarafına veri geçişi mümkün değil ..Tek yönlü
                 // Viewbag kullanımında sayfanın herhangi bir tazelenmesi veya baska bir sayfaya redirect yöntemiyle atlanılması sırasında içeri temizleniyor.
                 // eğer birden fazla viewbag kullanımı varsa en son tanımlanan geçerli durumda oluyor.
            ViewBag.Message = "Bu bir ViewBag den gelen mesajdır..";

            // ViewData
            // Esas farkı veriyi geriplanda tutmaya yönelik.
            List<Authors> authorlist = new List<Authors>();

            authorlist.Add(new Authors() { AuthorId = 1, AuthorName = "Stephen King", BookName = "It" });
            authorlist.Add(new Authors() { AuthorId = 2, AuthorName = "Aleander Dumas", BookName = "Three Musketeers" });
            authorlist.Add(new Authors() { AuthorId = 3, AuthorName = "Seth Godin", BookName = "Mor İnek" });
            authorlist.Add(new Authors() { AuthorId = 4, AuthorName = "Seymen Bozaslan", BookName = "İçinden Yol Geçen Hayatlar" });
            authorlist.Add(new Authors() { AuthorId = 5, AuthorName = "Erkin Yeşil", BookName = "Türkiye'nin Macera Rotaları" });
            authorlist.Add(new Authors() { AuthorId = 6, AuthorName = "Ayşegül Karaçivi", BookName = "Getirin Çekicimi...Kırılacak Kabuk Var" });

            ViewBag.Message = "Bu da ViewData ile taşınan bir veridir..";

            ViewData["Author"] = authorlist;


            return View();
        }
    }
}
