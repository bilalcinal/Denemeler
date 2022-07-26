using Microsoft.AspNetCore.Mvc;
using UdemyNet.Models;

namespace UdemyNet.ViewComponents
{
    public class News : ViewComponent
    {
        public IViewComponentResult Invoke(string color="default")
        {   
            var List = NewsContext.List;
            if (color==default)
                return View(List);
            else if(color=="red")
               return View("red", List);
            else 
               return View("blue", List);
        }
    }
}