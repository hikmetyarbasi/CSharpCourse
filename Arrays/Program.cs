using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = new string[3];
            strings[0] = "Hikmet";
            strings[1] = "Çiler";
            strings[2] = "Yarbaşı";

            string[] strings2 = new[] { "Hikmet", "Çiler", "Yarbaşı" };

            foreach (var item in strings2)
            {
                Console.WriteLine(item);
            }
            string[,] regions = new string[4, 3]
            {
                {"istanbul", "Balıkesir", "İzmir"},
                {"Ankara", "Konya", "Kırıkale"},
                {"Manisa", "Muğla", "İzmir"},
                {"Rize", "Trabzon", "Samsun"}
            };
            
            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
            }
            Console.Read();
        }
    }
}
