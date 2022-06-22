using System.Collections.Generic;

namespace UdemyNet.Models
{
    public static class CustomerContext
    {
        public static List<Customer> Customers = new()
        {
          new Customer {Id=1 ,Name="Bilal", Surname="Cinal", Age=22},
          new Customer {Id=2 ,Name="Enis", Surname="Cinal", Age=19},
          new Customer {Id=3 ,Name="Buğra", Surname="Cinal", Age=10}
        };
    }
}