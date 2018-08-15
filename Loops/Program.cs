using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //ForeachLoops();
            //DoWhileLoops();
            //ForLoop();
            //WhileLoops();
            if (IsPrimeNumber(8))
            { Console.WriteLine("This is a primenumber"); }
            else
            {
                Console.WriteLine("This is not a primenumber");
            }
            Console.Read();
        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number - 1; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    i = number;
                }
            }
            return result;
        }

        private static void ForeachLoops()
        {
            string[] strings2 = { "Hikmet", "Çiler", "Yarbaşı" };
            foreach (var item in strings2)
            {
                //item = "değiştirmek istiyorum"; foreach döngüsü içerisindeki değerleri değiştiremezsiniz.readonly
                Console.WriteLine(item);
            }
        }

        private static void DoWhileLoops()
        {
            var number = 0;
            do
            {
                number++;
            } while (number < 100);
        }

        private static void WhileLoops()
        {
            var number = 100;
            while (number != 0)
            {
                Console.WriteLine(number);
                number--;
            }
        }

        private static void ForLoop()
        {
            for (int i = 0; i <= 100; i = i + 2)
            {
                Console.WriteLine(i);
            }

            for (int i = 100; i <= 0; i = i - 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
