using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_4
{
    internal class Program
    {
        class Person
        {
            public int age;

            public void Print()
            {
                Console.WriteLine(age);
            }
        }

        static void Main(string[] args)
        {
            Person person = new Person();
            person.age = 25;
            person.Print();
        }
    }
}