using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5_1
{
    class Strategy
    {
        public virtual void Display()
        {
            Console.WriteLine("Strategy");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Strategy strategy = new Strategy();
            strategy.Display();
        }
    }
}
