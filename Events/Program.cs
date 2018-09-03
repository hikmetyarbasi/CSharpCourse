using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Product harddisk = new Product(50);
            harddisk.ProductName = "Harddisk";
            Product gsm = new Product(50);
            gsm.ProductName = "Gsm";
            gsm.StockControlEvent += Gsm_StockControlEvent;

            for (int i = 0; i < 5; i++)
            {
                gsm.Sell(10);
                harddisk.Sell(10);
                Console.ReadLine();
            }

            Console.ReadLine();
        }

        private static void Gsm_StockControlEvent(string text)
        {
            Console.WriteLine(text);
        }


    }
    public delegate void StockEvent(string text);
    public class Product
    {
        private int _stock;

        public Product(int stock)
        {
            _stock = stock;
        }
        public event StockEvent StockControlEvent;
        public string ProductName { get; set; }

        public int Stock
        {
            get
            {
                return _stock;
            }
            set
            {
                _stock = value;
                if (value <= 15)
                {
                    StockControlEvent?.Invoke($"{ProductName} is about to finish.Stock = {Stock}");
                }
            }

        }
        public void Sell(int amount)
        {
            Stock -= amount;
            Console.WriteLine("Product : {0} , Stock : {1}", ProductName, _stock);
        }
    }
}
