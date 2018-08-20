using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Program
    {
        //SOLID ==> I=> Interface Segregation   
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Robot(),
                new Worker()
            };

            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[2]
            {
                new Worker(),
                new Manager()
            };
            foreach (var eat in eats)
            {
                eat.Eat();
            }
        }

        interface IWorker
        {
            void Work();
        }

        interface IEat
        {
            void Eat();
        }

        interface IGetSalary
        {
            void GetSalary();
        }
        public class Worker : IWorker, IEat, IGetSalary
        {
            public void Work()
            {
                throw new NotImplementedException();
            }

            public void Eat()
            {
                throw new NotImplementedException();
            }

            public void GetSalary()
            {
                throw new NotImplementedException();
            }
        }

        public class Manager : IWorker, IEat, IGetSalary
        {
            public void Work()
            {
                throw new NotImplementedException();
            }

            public void Eat()
            {
                throw new NotImplementedException();
            }

            public void GetSalary()
            {
                throw new NotImplementedException();
            }
        }
        public class Robot : IWorker
        {
            public void Work()
            {
                throw new NotImplementedException();
            }
        }
    }
}
