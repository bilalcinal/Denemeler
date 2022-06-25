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
        public IActionResult CreateWithForm()
      
        {
            var name = HttpContext.Request.Form["name"].ToString();
            var surname = HttpContext.Request.Form["surname"].ToString();
            var age = int.Parse(HttpContext.Request.Form["age"].ToString());

          Customer lastCustomer = null;
          if(CustomerContext.Customers.Count >0)
          {
               lastCustomer = CustomerContext.Customers.Last();
          }
           int id=1;
          
            if(lastCustomer != null)
            {
              id= lastCustomer.Id+1;
            }
            

          CustomerContext.Customers.Add(new Customer
           {
              Age = age,
              Id = id,
              Name = name,
              Surname = surname
            });
  
            
          return RedirectToAction("Index");
        }
       
        [HttpGet]
        public IActionResult Remove()
        
        {
           var id = int.Parse(RouteData.Values["id"].ToString());
           var removedCustomer =  CustomerContext.Customers.Find(I =>I.Id == id);
           CustomerContext.Customers.Remove(removedCustomer);
             return RedirectToAction("Index");
        }

        
        [HttpGet]
        public IActionResult Update()
        {
          var id=int.Parse(RouteData.Values["id"].ToString());
          var updatedCustomer = CustomerContext.Customers.FirstOrDefault(a=> a.Id == id);
          return View(updatedCustomer);
        }

        
       [HttpPost]
        public IActionResult UpdateCustomer()
        {
            var id=int.Parse(HttpContext.Request.Form["id"].ToString());
            var updatedCustomer = CustomerContext.Customers.FirstOrDefault(I=>I.Id == id);
            updatedCustomer.Name=HttpContext.Request.Form["name"].ToString();
            updatedCustomer.Surname=HttpContext.Request.Form["surname"].ToString();
            updatedCustomer.Age=int.Parse(HttpContext.Request.Form["age"].ToString());
            return RedirectToAction("Index");
}
   
    }
}