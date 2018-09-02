using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        public delegate void Mydelegate();
        public delegate void Mydelegate2(string message);

        public delegate int Mydelegate3(int a, int b);

        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            Mydelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.ShowAlert;

            Mydelegate2 mydelegate2 = customerManager.SendMessage;


            //ard arda çalışmasını istediğin metotlar grubu için delegate'leri kullanabilirsiniz.Örneğin bir yemek 
            //yapmak için sırasıyla yapılan işlemleri bir metot olarak tanımlayıp hepsini delegate değişkenine atarsak 
            //sadece delegate metotunu çağırmamız yeterli olacaktır.
            DortIslem dortIslem = new DortIslem();


            Mydelegate3 mydelegate3 = dortIslem.Carp;
            mydelegate3 += dortIslem.Topla;

            myDelegate();
            mydelegate2("Selamunaleyküm");
            mydelegate3(2, 4);

            Console.Read();
        }
    }

    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello");
        }

        public void ShowAlert()
        {
            Console.WriteLine("Be Careful!");
        }
        public void SendMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void ShowAlert(string message)
        {
            Console.WriteLine(message);
        }
    }

    class DortIslem
    {
        public int Carp(int a, int b)
        {
            var result = a * b;
            Console.WriteLine(result);
            return result;
        }
        public int Topla(int a, int b)
        {
            var result = a + b;
            Console.WriteLine(result);
            return result;
        }
    }
}
