using Microsoft.AspNetCore.Mvc;
using UdemyNet.Models;

namespace UdemyNet.ViewComponents
{
    public class News : ViewComponent
    {
        public IViewComponentResult Invoke()
        {   
            var List = NewsContext.List;
            return View(List);
        }
    }
}