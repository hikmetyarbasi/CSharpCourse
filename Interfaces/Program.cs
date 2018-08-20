using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetStartedInterface();
            //CustomerManage();


            Console.Read();
        }

        private static void CustomerManage()
        {
            CustomerManager manager = new CustomerManager();
            manager.Add(new OracleSqlCustomerDal());
        }

        public interface ICustomerDal
        {
            void Add();
            void Delete();
            void Update();
        }

        public class OracleSqlCustomerDal : ICustomerDal
        {
            public void Add()
            {
                Console.WriteLine("Oracle Data Added");
            }

            public void Delete()
            {
                Console.WriteLine("Oracle Data Deleted");
            }

            public void Update()
            {
                Console.WriteLine("Oracle Data Updated");
            }
        }
        public class MsSqlCustomerDal : ICustomerDal
        {
            public void Add()
            {
                Console.WriteLine("MSsql Data Added");
            }

            public void Delete()
            {
                Console.WriteLine("MSsql Data Deleted");
            }

            public void Update()
            {
                Console.WriteLine("MSsql Data Updated");
            }
        }

        public class CustomerManager
        {
            public void Add(ICustomerDal dal)
            {
                dal.Add();
            }
        }

        private static void GetStartedInterface()
        {
            var cust = new Customer { FirstName = "hikmet", Address = "istanbul", Id = 1, LastName = "yarbasi" };
            var student = new Student() { FirstName = "Çiler", LastName = "Yarbaşı", Id = 2, Departmant = "Service Yönetim Hizmetleri" };
            PersonManager manager = new PersonManager();
            manager.Add(cust);
            manager.Add(student);
        }

        public interface IPerson
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }
        }

        public class Customer : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
        }

        public class Student : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Departmant { get; set; }
        }

        public class PersonManager
        {
            public void Add(IPerson person)
            {

                Console.WriteLine("Person Added with name : {0}", person.FirstName);

            }
        }
    }
}
