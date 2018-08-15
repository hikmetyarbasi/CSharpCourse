using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "My name is hikmet yarbaşı";
            var lenght = name.Length;
            var nameclone = name.Clone();// değer clone'landıktan sonra değiştirilirse clonlanan değeretkilenmez.
            name = "My name is çiler yarbaşı";

            bool result = name.StartsWith("J");
            bool result2 = name.EndsWith("H");

            var result3 = name.IndexOf("name");//bulamazsa -1 değeri döndürür.
            var result4 = name.LastIndexOf("name", StringComparison.Ordinal);//aramaya sondan başlar.
            var result5 = name.Insert(2, "delimisin nesin ?");
            var result6 = name.Substring(2, 4);
            var result7 = name.ToLower();
            var result8 = name.ToUpper();
            var result9 = name.Replace(" ", "-");
            var result10 = name.Remove(2,4);//2 den itibaren uçur 4 tane.
            Console.WriteLine(result6);    
            Console.Read();
        }

        private static void GetValue()
        {
            string city = "Ankara";
            string city2 = "İstanbul";

            foreach (var charackter in city)
            {
                Console.WriteLine(charackter);
            }
            Console.WriteLine("{0} {1}", city2, city);
        }
    }
}

