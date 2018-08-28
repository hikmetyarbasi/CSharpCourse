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

            HandleException(() =>
            {
                Find();
            });


            Console.ReadLine();
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
