using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5_7
{
    interface IPrintable
    {
        void Display();
    }

    class ConsolePrinting : IPrintable
    {
        public void Display()
        {
            Console.WriteLine("My Console");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsolePrinting printer = new ConsolePrinting();
            printer.Display();
        }
    }
}
