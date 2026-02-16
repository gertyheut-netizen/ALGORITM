using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_6
{
    class Person
    {
        private int age; 

  
        public Person()
        {
            age = 18; 
        }
        public void Print()
        {
            Console.WriteLine("Возраст: " + age);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Print();
        }
    }
}