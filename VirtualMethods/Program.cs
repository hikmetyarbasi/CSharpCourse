using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Database[] databases = new Database[3]
            {
                new Database(),
                new MySql(),
                new SqlServer()
            };
            foreach (var database in databases)
            {
                database.Add();
            }
            Console.ReadLine();
        }
    }


    public class Database
    {
        //Override edilebilir özelliği kazandırmak için virtual keyword'ünü ekliyoruz.
        public virtual void Add()
        {
            Console.WriteLine("Data Added at Base Class");
        }

        public virtual void Delete()
        {
            Console.WriteLine("Data Deleted at base class");
        }
    }

    public class SqlServer : Database
    {
        public override void Add()
        {
            Console.Write("Data Added at SqlServer Class");
        }

        public override void Delete()
        {
            Console.WriteLine("Data deleted by sqlserver class");
        }
    }

    public class MySql : Database
    {
        public override void Add()
        {
            base.Add();
            Console.WriteLine("data Added by mysql class");

        }

        public override void Delete()
        {
            base.Delete();
            Console.WriteLine("Data Deleted by Mysql class");
        }
    }
}
