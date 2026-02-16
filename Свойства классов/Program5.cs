using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_5
{
    internal class Program
    {
        class Product
        {
            protected string name;

            public Product()
            {
                name = "Рамиль";
            }

            public string Name
            {
                get { return name; }
              
            }
        }
        static void Main(string[] args)
        {
            Product product = new Product();
            Console.WriteLine(product.Name);
        }
    }
}
