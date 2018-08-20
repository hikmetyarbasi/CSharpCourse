using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            ;
            Person[] persons = new Person[3]
            {
                new Person() {FirstName = "Hikmet"},
                new Customer() {FirstName = "Çiler"},
                new Student() {FirstName = "Kemal"}
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
            Console.ReadLine();
        }
    }

    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class Customer : Person
    {
        public string City { get; set; }

    }

    public class Student : Person
    {
        public string Departmant { get; set; }
    }
}