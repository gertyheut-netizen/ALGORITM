using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_5
{
    internal class Program
    {
        class Table
        {
            public int rows;
            public int cols;

            public void Display()
            {
                Console.WriteLine($"Строки: {rows}, Столбцы: {cols}");
            }
        }

        static void Main(string[] args)
        {
            Table table = new Table();
            table.rows = 5;
            table.cols = 3;
            table.Display();
        }
    }
}
