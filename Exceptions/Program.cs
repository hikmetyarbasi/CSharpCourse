using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro();

            //TryCatch();

            //ActionDemo();

            //Delege olarak düşünülebilen ve dönüş tipi olan nesnelerdir.


            //FuncDemo();

            Console.ReadLine();
        }
            
        private static void FuncDemo()
        {
            Func<int, int, int> func = Topla;
            func += Carp;

            Func<int, int> func2 = a => a;

            Func<int> func3 = delegate() { return new Random().Next(1, 100); };

            Func<int> func4 = () => new Random().Next(1, 100);

            Console.WriteLine(func(4, 2));
            Console.WriteLine(func2(2));
            Console.WriteLine(func3());
            Console.WriteLine(func4());
        }

        public static int Carp(int a, int b)
        {
            return a * b;
        }

        public static int Topla(int a, int b)
        {
            return a + b;
        }

        private static void ActionDemo()
        {
            //Action void dönüş tipi olan delegelerdir.
            HandleException(() =>
            {
                Find();
            });
        }

        private static void TryCatch()
        {
            try
            {
                Find();
            }
            catch (RecordNotFound exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);

            }
        }

        private static void Find()
        {
            List<string> list = new List<string>() { "Taha", "Tuğra", "Tuğce" };

            if (!list.Contains("Hikmet"))
            {
                throw new RecordNotFound("Hikmet listede bulunamadı!");
            }
        }

        private static void ExceptionIntro()
        {
            try
            {
                string[] cities = new string[] { "Ankara", "İstanbul", "İzmir" };

                cities[3] = "Samsun";
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
