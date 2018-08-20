using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Student(1, 2);
            ((Student)person).Save();
            Console.Read();
        }
    }

    public class Person
    {
        public Person(int protectedId, int privateId)
        {
            this.ProtectedId = protectedId;
            this.PrivateId = privateId;
        }

        protected int ProtectedId { get; set; }
        private int PrivateId { get; set; }

    }

    public class Student : Person
    {
        public Student(int protectedId, int privateId) : base(protectedId, privateId)
        {

        }

        public void Save()
        {
            Console.WriteLine(ProtectedId);
            Console.WriteLine("You cannot access private properties from base child privateId is not recognizable.");
        }
    }
    /// <summary>
    /// Access Modifiers'ı internal olarak tanımlanan sınıflar sadece kendi Assembly içerisinde 
    /// reference gösterilmeden çağrılabilen sınıflardır.Farkı bir assembly'e reference olarak eklenmiş olsa bile
    /// erişilemez class'lardır.Sadece kendi assembly 'si içerisinde kullanılabilir ve implemente edilebilir.
    /// </summary>
    internal class MyInternalClass
    {
        public void Access()
        {
            Console.WriteLine("Yes You can access!");
        }
    }
}
