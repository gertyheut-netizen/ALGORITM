using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5_6
{
    internal class Program
    {
        abstract class Entity
        {
            public abstract void Display();
        }
        class Product : Entity
        {
            public override void Display()
            {
                Console.WriteLine("My Product");
            }
        }

        static void Main(string[] args)
        {
            Product product = new Product();
            product.Display();
        }
    }
}
