using Microsoft.AspNetCore.Mvc;
using UdemyNet.Models;

namespace UdemyNet.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index(int id)
        {
             return View();
           
        }
    }
}