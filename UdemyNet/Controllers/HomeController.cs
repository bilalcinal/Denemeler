using Microsoft.AspNetCore.Mvc;
using UdemyNet.Models;

namespace UdemyNet.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            var customers = CustomerContext.Customers;  
            
            return View(customers);
        }

        public IActionResult Bilal(int id)
        {
             return View();

        }
    }
}