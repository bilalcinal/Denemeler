using System.IO;
using Microsoft.AspNetCore.Mvc;

namespace UdemyNet.Controllers
{
    public class FolderController : Controller
    {
        public IActionResult List()
        {
          DirectoryInfo directoryInfo= new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot"));
          var folders = directoryInfo.GetDirectories();
           return View(folders);
        }
    }
}