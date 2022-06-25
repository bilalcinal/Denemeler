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
            return View(new Customer());
        }
      
        
        [HttpPost]
        public IActionResult Create(Customer customer)
      
        {
            // var name = HttpContext.Request.Form["name"].ToString();
            // var surname = HttpContext.Request.Form["surname"].ToString();
            // var age = int.Parse(HttpContext.Request.Form["age"].ToString());

          Customer lastCustomer = null;
          if(CustomerContext.Customers.Count >0)
          {
               lastCustomer = CustomerContext.Customers.Last();
          }
           customer.Id=1;
          
            if(lastCustomer != null)
            {
              customer.Id= lastCustomer.Id+1;
            }
            

          CustomerContext.Customers.Add(customer);
  
            
          return RedirectToAction("Index");
        }
       
        [HttpGet]
        public IActionResult Remove(int id)
        
        {
          //  var id = int.Parse(RouteData.Values["id"].ToString());
           var removedCustomer =  CustomerContext.Customers.Find(I =>I.Id == id);
           CustomerContext.Customers.Remove(removedCustomer);
             return RedirectToAction("Index");
        }

        
        [HttpGet]
        public IActionResult Update(int id)
        {
          // var id=int.Parse(RouteData.Values["id"].ToString());
          var updatedCustomer = CustomerContext.Customers.FirstOrDefault(a=> a.Id == id);
          return View(updatedCustomer);
        }

        
       [HttpPost]
        public IActionResult Update(Customer customer)
        {
            // var id=int.Parse(HttpContext.Request.Form["id"].ToString());

            var updatedCustomer = CustomerContext.Customers.FirstOrDefault(I=>I.Id == customer.Id);

            // updatedCustomer.Name=HttpContext.Request.Form["name"].ToString();
            // updatedCustomer.Surname=HttpContext.Request.Form["surname"].ToString();
            // updatedCustomer.Age=int.Parse(HttpContext.Request.Form["age"].ToString());
            updatedCustomer.Name = customer.Name;
            updatedCustomer.Surname = customer.Surname;
            updatedCustomer.Age = customer.Age;

            return RedirectToAction("Index");
}
   
    }
}