using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Recap_Demo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager manager = new CustomerManager();
            manager.Logger = new FileLogger();
            manager.Add();
            Console.Read();
        }

    }

    public class CustomerManager
    {
        public ILogger Logger { get; set; }

        public void Add()
        {
            Logger.Log();
            Console.WriteLine("Customer Added");
        }
    }

    public class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Database Logged!");
        }
    }
    public class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("File Logged!");
        }
    }
    public class SmsLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Sms Logged!");
        }
    }
    /// <summary>
    /// Eğer Log Methodum implement edildiği sınıflarda farklılık gösteriyorsa bu şekilde kodlamak
    /// mantıklı olacaktır.Ama Database ve File da aynı Sms te farklılık göstericekse bunu abstract class
    /// içerisinde virtual methodlar ile yönetmek daha mantıklı olacaktır.Bunlar sizin ihtiyacınıza bağlı
    /// olarak değişecek olan kod tasarımlarıdır.
    /// </summary>
    public interface ILogger
    {
        void Log();
    }
}
