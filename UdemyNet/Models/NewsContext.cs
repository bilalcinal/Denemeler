using System.Collections.Generic;

namespace UdemyNet.Models
{
    public static class NewsContext
    {
        public static List<News> List = new()
        {
          new News { Title="Haber 1"},

          new News { Title="Haber 2"}
          
        };
    }
}