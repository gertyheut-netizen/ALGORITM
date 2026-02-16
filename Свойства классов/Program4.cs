using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_4
{
    internal class Program
    {
        class Car
        {
            public string Name { get; set; }
            public string Color { get; set; }

            public Car() { }
        }
        static void Main(string[] args)
        {
            Car car = new Car { Name = "KIA SOUL", Color = "green" };
            Console.WriteLine($"{car.Name} - {car.Color}");
        }
    }
}
