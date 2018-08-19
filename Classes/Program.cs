using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customer = new CustomerManager();
            customer.Add();
            customer.Update();
            Product product = new Product();
            product.Add();
            product.Updated();

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "Hikmet";
            customer2.LastName = "Yarbaşı";
            customer2.City = "Erzurum";


            Customer customer3 = new Customer
            {
                Id = 1,
                FirstName = "Çiler",
                LastName = "Yarbaşı",
                City = "İzmir"
            };

            Console.WriteLine(customer3.FirstName);
            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("Customer Added");
        }
        public void Update()
        {
            Console.WriteLine("Customer Updated");
        }
    }
}
