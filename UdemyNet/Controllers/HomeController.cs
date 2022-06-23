using Microsoft.AspNetCore.Mvc;
using UdemyNet.Models;

namespace UdemyNet.Controllers
{
    public class HomeController:Controller
    { 
        [HttpGet]
        public IActionResult Index()
        {
            var customers = CustomerContext.Customers;  
            
            return View(customers);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
      
       [HttpPost]
        public IActionResult CreatWithForm()
      
        {
          return RedirectToAction("Create");
        }

    }
}