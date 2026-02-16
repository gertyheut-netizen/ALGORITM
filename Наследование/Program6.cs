using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4_6
{
    class Animal
    {
        protected int age;
    }

    class Predator : Animal
    {
        public void SetAge(int age)
        {
            this.age = age; // доступно, т.к. protected
        }

        public void ShowAge()
        {
            Console.WriteLine($"Возраст хищника: {age}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
