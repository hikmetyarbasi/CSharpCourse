using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracts
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new Mssql();
            database.Add();
            database.Deteled();
            Database database2 = new Oracle();
            database2.Add();
            database2.Deteled();
            Console.Read();
        }
    }

    public abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Database Add Function is same for all child.");
        }
        //Base Class'taki herhangi bir metotun child class'larda implementasyonu mecburi kılmak istiyorsanız 
        //abstrac olarak işaretlemek zorundasınız.
        public abstract void Deteled();
    }

    public class Mssql : Database
    {
        public override void Deteled()
        {
            Console.WriteLine("MSsql Data Deleted");
        }
    }

    public class Oracle : Database
    {
        public override void Deteled()
        {
            Console.WriteLine("Oracle Data Deleted");
        }

    }
}
