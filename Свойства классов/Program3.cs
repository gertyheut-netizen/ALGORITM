using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_3
{
    internal class Program
    {
        class Car
        {
            private int year;

            public Car() { }

            public int Year
            {
                get { return year; }
                set
                {
                    if (value > 0)
                        year = value;
                }
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
