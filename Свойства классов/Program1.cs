using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_1
{
    internal class Program
    {
        class Student
        {
            public string Name { get; set; }
        }
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "Анна";
            Console.WriteLine(student.Name);
        }
    }
}
