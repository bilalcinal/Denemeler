using Microsoft.AspNetCore.Mvc;

namespace UdemyNet.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = " Bilal";
            ViewData["Name"] = "Hakkı";
            TempData["Name"] = "Cinal";
               return View();
        }

        public IActionResult Bilal()
        {
             return View();

        }
    }
}