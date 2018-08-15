using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    public class Program
    {
        static void Main(string[] args)
        {
            var day = "Monday";

            if (Days.Monday.ToString() == day)
            {
                Console.WriteLine("Day is {0}", day);
            }
            //decimal daha küsüratlı verileri tutabilmek için kullanılır.
            decimal numberDecimal = 4.33m;
            //double veritipi ondalıklı verileri tutmak için kullanılır.
            double numberdouble = 4.3;

            char character = 'A';
            //byte 8 bit yer kaplar.8 bit 1 byte yapar
            byte numberbyte = 0;
            numberbyte = 255;
            //short 16 bit yer kaplar
            short numbershort = 32767;
            numbershort = -32768;
            //int 32 bit integer değer saklar.
            int numberint = 2147483647;
            numberint = -2147483648;

            //long , 64 bit integer değer kaplar.
            long numberlong = 9223372036854775807;
            numberlong = -9223372036854775808;

            Console.WriteLine("numberdouble is {0}", numberdouble);
            Console.WriteLine("Character ASCII code is {0}", (int)character);
            Console.WriteLine("byte  is {0}", numberbyte);
            Console.WriteLine("numbershort  is {0}", numbershort);
            Console.WriteLine("numberint  is {0}", numberint);
            Console.WriteLine("numberlong  is {0}", numberlong);
            Console.WriteLine("numberdouble  is {0}", numberdouble);
            Console.WriteLine("numberdecimal  is {0}", numberDecimal);
            Console.ReadLine();
        }

        enum Days
        {
            Monday, Sunday, Tuesday, Wednesday, Thursday, Friday, Saturday
        }
    }
}
