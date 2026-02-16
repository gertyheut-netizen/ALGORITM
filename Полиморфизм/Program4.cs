using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5_4
{
    class Animal
    {
        private string type;

        public Animal()
        {
            type = "My Type";
        }

        public virtual void Print()
        {
            Console.WriteLine(type);
        }
    }

    class Cat : Animal
    {
        private int age;

        public Cat()
        {
            age = 5;
        }

        public override void Print()
        {
            Console.WriteLine(age);
        }
}

    internal class Program
    {
        static void Main(string[] args)
        {

            Animal animal = new Animal();
            Cat cat = new Cat();

            animal.Print();
            cat.Print();
        }
    }
}
