using Microsoft.AspNetCore.Mvc;
using UdemyNet.Models;

namespace UdemyNet.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = " Bilal";
            ViewData["Name"] = "Hakkı";
            TempData["Name"] = "Cinal";

            Customer customer = new() {Age = 22 , Name="Bilal",Surname="Cinal "};
               return RedirectToAction("Index" , "Product" , new {@id=1});
        }

        public IActionResult Bilal(int id)
        {
             return View();

        }
    }
}