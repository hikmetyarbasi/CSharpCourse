using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {


        static void Main(string[] args)
        {
            Utilities ut = new Utilities();
            var result = ut.BuildList<string>(new[]
            {
                "hikmet","çiler","Yarbaşı"
            });
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            var result2 = ut.BuildList(new Customer() { FirstName = "Salim" }, new Customer() { FirstName = "Kemal" }, new Customer() { FirstName = "Namık" });
            foreach (var c in result2)
            {
                Console.WriteLine(c.FirstName);
            }
            Console.ReadLine();
        }

    }


    class Utilities
    {
        public List<T> BuildList<T>(params T[] list)
        {
            return list.ToList();
        }
    }
}
