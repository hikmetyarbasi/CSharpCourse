using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal interface IRepository<T>
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }

    internal interface ICustomerDal : IRepository<Customer>
    {


    }

    internal interface IProductDal : IRepository<Product>
    {
        void GetCustomProduct(int id);

    }

    public class Customer : ICustomerDal
    {
        public string FirstName { get; set; }
        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
    public class Product : IProductDal
    {
        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public void GetCustomProduct(int id)
        {
            throw new NotImplementedException();
        }
    }
}
