using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5_2
{
    class Weather
    {
        public virtual void Show()
        {
            Console.WriteLine("My Weather");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Weather weather = new Weather();
            weather.Show();
        }
    }
}
