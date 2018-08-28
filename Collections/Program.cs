using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arraylist();

            //StringCollection();

            //List(); 

            Dictionary<int, Customer> dics = new Dictionary<int, Customer>
            {
                { 1, new Customer() { Id = 1, FirstName = "hikmet" } },
                { 2, new Customer() { Id = 2, FirstName = "ciler" } },
                { 3, new Customer() { Id = 3, FirstName = "fatih" } },
                { 4, new Customer() { Id = 4, FirstName = "funda" } }
            };

            foreach (var item in dics)
            {
                Console.WriteLine(item.Value.FirstName);
            }
            dics.ContainsKey(2);
            dics.ContainsValue(new Customer());
            Console.ReadLine();
        }

        private static void List()
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer(){Id = 2,FirstName = "çiler"},
                new Customer(){Id = 3,FirstName = "mehmet"}
            };

            customers.Add(new Customer() { Id = 1, FirstName = "hikmet" });

            var customer2 = new Customer() { Id = 4, FirstName = "funda" };
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }

            //Buradaki kritik konu referens olarak gösterilen nesnenin dizi içerisinde olup olmadığıdır.
            //Id 1  firstname hikmet olması dizi içerisinde olduğu anlamına gelmez.result burada false döner.
            var result = customers.Contains(new Customer() { Id = 1, FirstName = "hikmet" });

            //Lakin array içerisinde customer2 nesnesini contains methodu ile doprulamak istediğimiz zaman true yanıtını alabiliri.z
            result = customers.Contains(customer2);
            customers.Add(customer2);

            var customerorder = customers.IndexOf(customer2);
            Console.WriteLine("customer2 order : {0}", customerorder);
            var customerorderfromlast = customers.LastIndexOf(customer2);
            Console.WriteLine("customer2 order from Last : {0}", customerorderfromlast);

            //her seferinde 1 tane eleman listeden çıkarır
            customers.Remove(customer2);
            //Bütün fundaları listeden çıkarrı.
            customers.RemoveAll(c => c.FirstName == "funda");

            var count = customers.Count;

            customers.Clear();
        }

        private static void StringCollection()
        {
            List<string> list = new List<string>();
            list.Add("Ankara");
            list.Add("Adana");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        private static void Arraylist()
        {
            ArrayList arraylist = new ArrayList();
            arraylist.Add("Ankara");
            arraylist.Add("Adana");
            arraylist.Add(1);
            arraylist.Add(1.2m);

            foreach (var item in arraylist)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
