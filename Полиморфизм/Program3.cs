using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5_3
{
    class Strategy
    {
        public virtual void Display()
        {
            Console.WriteLine("Strategy");
        }
    }

    class ConservativeStrategy : Strategy
    {
        public override void Display()
        {
            Console.WriteLine("Conservative Strategy");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Strategy strategy1 = new Strategy();
            Strategy strategy2 = new ConservativeStrategy();

            strategy1.Display(); 
            strategy2.Display();
        }
    }
}
