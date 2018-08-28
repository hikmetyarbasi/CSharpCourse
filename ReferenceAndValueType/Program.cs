using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int number2 = 10;
            number = number2;
            number2 = 30;
            //Değer tipleri üzerinde değerleri taşıdıkları için eşitleme yapıldığında birbirine karşı bağımlılık oluşturmazlar.
            //Console.WriteLine(number);


            string[] city1 = { "Ankara", "Elazığ", "Kırklareli" };
            string[] city2 = { "Bolu", "Bursa", "Balıkesir" };

            //referans tipi oldukları için ram üzerinde her 2 değişkende aynı değeri tutmaktadır
            //eğer herhangi bir referans tipinde değişiklik gerçekleştirilirse her ikisde değişecektir.

            city1 = city2;
            city2[0] = "İstanbul";

            Console.WriteLine("{0}", city1[0]);
            city1[0] = "Bolu";
            Console.WriteLine("{0}", city2[0]);
            Console.Read();
        }
    }
}
