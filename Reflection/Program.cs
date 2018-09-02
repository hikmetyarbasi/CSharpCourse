using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortislem = new DortIslem(4, 5);
            DortIslem dortislemctr = new DortIslem();

            Console.WriteLine(dortislemctr.Carp(2, 4));
            Console.WriteLine(dortislem.Topla2());

            var tip = typeof(DortIslem);

            var instance = (DortIslem)Activator.CreateInstance(tip, 3, 3);
            instance.Carp(2, 3);
            instance.Topla(2, 2);

            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");

            Console.WriteLine(methodInfo.Invoke(instance, null));

            Console.WriteLine("--------------------------------------");

            var methods = instance.GetType().GetMethods();

            foreach (var method in methods)
            {
                Console.WriteLine("DortIslem Method  :  {0}", method.Name);
                var parameters = method.GetParameters();
                foreach (var parameter in parameters)
                {
                    Console.WriteLine("Parameters :  {0}", parameter.Name);
                }
                var attributes = method.GetCustomAttributes();

                foreach (var attribute in attributes)
                {
                    Console.WriteLine("Attributes  : {0}", attribute.GetType().Name);
                }
            }

            Console.ReadLine();
        }
    }

    class DortIslem
    {
        private int _sayi1;
        private int _sayi2;

        public DortIslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;

        }
        public DortIslem()
        {

        }
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }
        [MethodName("Çarpma")]
        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }
    }

    public class MethodNameAttribute : Attribute
    {
        public MethodNameAttribute(string method)
        {

        }
    }
}
