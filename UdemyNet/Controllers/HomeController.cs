using Microsoft.AspNetCore.Mvc;

namespace UdemyNet.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
               return View();
        }

        public IActionResult Bilal()
        {
             return View();

        }
    }
}