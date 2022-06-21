using System.Collections.Generic;

namespace UdemyNet.Models
{
    public static class CustomerContext
    {
        public static List<Customer> Customers = new()
        {
          new Customer {Name="Bilal", Surname="Cinal", Age=22},
          new Customer {Name="Enis", Surname="Cinal", Age=19},
          new Customer {Name="Buğra", Surname="Cinal", Age=10}
        };
    }
}