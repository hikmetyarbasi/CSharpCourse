using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    [ToTable("Customer")]
    [ToTable("tbkCustomer")]
    public class Customer
    {
        //[RequeiredProperty]
        [RequeiredProperty]
        public int Id { get; set; }
        [RequeiredProperty]
        public string FirstName { get; set; }
        [RequeiredProperty]
        public string LastName { get; set; }
        [RequeiredProperty]
        public int Age { get; set; }
    }
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Delegate, AllowMultiple = true)]
    public class ToTableAttribute : Attribute
    {
        private string v;

        public ToTableAttribute(string v)
        {
            this.v = v;
        }
    }
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    class RequeiredPropertyAttribute : Attribute
    {

    }
}
