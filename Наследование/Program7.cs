using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4_7
{
    internal class Program
    {
        class Transport
        {
            protected string name;
        }

        class SpaceShuttle : Transport
        {
            public void SetName(string name)
            {
                this.name = name; // доступно, т.к. protected
            }

            public void Show()
            {
                Console.WriteLine($"Название шаттла: {name}");
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
