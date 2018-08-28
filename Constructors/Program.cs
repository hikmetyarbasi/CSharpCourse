using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Build.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager manager = new CustomerManager(12);
            manager.List();


            Product product = new Product() { Id = 1, Name = "Laptop" };
            Product prduct2 = new Product(2, "Mouse");
            Product product3 = new Product("Telefon");
            product3.Add();

            ProductManager prodmanager = new ProductManager(new DatabaseLogger());
            prodmanager.Add();

            Console.Read();
        }
    }

    class CustomerManager
    {
        public CustomerManager(int count)
        {
            _count = count;
        }

        public CustomerManager()
        {

        }
        private int _count;
        public void Add()
        {
            Console.WriteLine("Added!");
        }

        public void List()
        {
            Console.WriteLine("Listed {0} items", _count);
        }
    }

    public class Product : BaseProd
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Product(string entity) : base(entity)
        {

        }

        public Product()
        {

        }

        public Product(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void Add()
        {
            Message();
        }
    }


    public class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Database");
        }
    }
    public class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to File");
        }
    }

    public class ProductManager
    {
        private ILogger _logger { get; set; }

        public ProductManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Product Added!");
        }

    }
    public interface ILogger
    {
        void Log();
    }

    public class BaseProd
    {
        protected string _entity;
        public BaseProd(string entity)
        {
            _entity = entity;
        }

        protected void Message()
        {
            Console.WriteLine("{0} message", _entity);
        }

        protected BaseProd()
        {

        }
    }

    static class Utilitize
    {
        public static bool Validate(string value)
        {
            Console.WriteLine("Value is checked if it is valid it return true or false...");
            return true;
        }

        public static string FirstName { get; set; }
    }

    class Manager
    {
        public static void DoSomething()
        {

        }

        public void DoSomething2()
        {
            
        }
    }
}
