using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_5
{
    internal class Program
    {
        class Product
        {
            protected string name;

            public Product(Product other)
            {
                name = other.name;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
