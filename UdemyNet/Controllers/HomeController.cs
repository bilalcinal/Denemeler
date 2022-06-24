using System.Linq;
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
            var name = HttpContext.Request.Form["name"].ToString();
            var surname = HttpContext.Request.Form["surname"].ToString();
            var age = int.Parse(HttpContext.Request.Form["age"].ToString());

            var lastCustomer=CustomerContext.Customers.Last();

            var id=lastCustomer.Id+1;

          CustomerContext.Customers.Add(new Customer
           {
              Age = age,
              Id = id,
              Name = name,
              Surname = surname
            });
  
            
          return RedirectToAction("Create");
        }

    }
}