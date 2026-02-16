using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_4

    class Car
    {
        public string name;
        public string color;

        public Car(string name, string color)
        {
            this.name = name;
            this.color = color;
        }
    }
    class Program
    {
        static void Main()
        {
          
            Car lada = new Car("LADA VESTA", "black");
            Car bmw = new Car("BMW X5", "white");

           
            Console.WriteLine($"Lada: {lada.name}, {lada.color}");
            Console.WriteLine($"BMW: {bmw.name}, {bmw.color}");

           
        }
    }
