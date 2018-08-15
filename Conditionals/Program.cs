using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var number = 10;

            //Comment ekleme kısayolu Ctrl+K dan sonra Ctrl + C.Kaldırma Ctrl + K ve Ctrl+U
            switch (number)
            {
                case 10:
                    Console.WriteLine("Number is {0}", number);
                    break;
                case 20:
                    Console.WriteLine("Number is 20");
                    break;
                default:
                    Console.WriteLine("Number is not {0}", number);
                    break;
            }

            if (number >= 0 && number < 100)
            {
                Console.WriteLine("Number is between 0-100");
            }
            else if(number >=100&& number<200)
            {
                Console.WriteLine("Number is between 100-200");
            }
            else if(number>200||number<0)
            {
                Console.WriteLine("Number is out of range");
            }

            Console.Read();
        }
    }
}
