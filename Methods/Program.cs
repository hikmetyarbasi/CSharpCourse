using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Add(6);
            Console.WriteLine("Total is {0}", result);


            //değer tipleri gönderildikten metotların içerisinde değiştirilemez çünkü metotlara sadece değerleri gönderilmektedir.Tuttuğu değerler sabit olarak kalmaktadır.

            var number1 = 20;
            var number2 = 40;
            var number3 = 19;
            result = Add2(number1, number2);
            //number1 değeri add2 metotu içerisinde değiştirilmiş olmasına rağmen yukarıda atanan 20 değeri ekrana yazılacaktır.
            Console.WriteLine("Total is {0}", result);
            Console.WriteLine("number1 is {0}", number1);

            //referense tipleri ile çalışıyorsak metot içerisine ref keyword ü ile gönderilen değişkenler metottaki değişikliklerden etkilenirler.
            result = Add3(ref number1, number2);
            Console.WriteLine("ref number1 is {0}", number1);

            //ref ile out arasındaki farklar: 1) ref kullanıldığında değişken initialize edilmeli 2) out kullanıldığında değişken metot içerisinde en az bir kere değer atanmalı.
            result = Add4(out number1, number2);
            Console.WriteLine("out number1 is {0}", number1);
            //Metot multiply overload with 2 and 3 parameters via same metot name
            var multiply = Multiply(number1, number2);
            Console.WriteLine("Overload metot 1 with two parameters and same metot name result is {0}", multiply);
            multiply = Multiply(number1, number2, number3);
            Console.WriteLine("Overload metot 2 with three parameters and same metot name result is {0}", multiply);

            //params keywordü kullanarak aynı tipte birden çok parametre gönderilebilmektedir.
            result = Add(1, 23, 4, 56, 7, 5);
            Console.WriteLine("Result with params keywords is {0}", result);
            Console.Read();
        }

        public static int Add(int x, int a = 30, int b = 20)
        {
            return a + b;
        }

        public static int Add2(int number1, int number2)
        {
            return number1 + number2;
        }
        public static int Add3(ref int number1, int number2)
        {
            number1 = 144;
            return number1 + number2;
        }

        public static int Add4(out int number1, int number2)
        {
            number1 = 10;
            return number1 + number2;
        }

        public static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        //Multiply metotu overload olmuştur.
        public static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        public static int Add(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
