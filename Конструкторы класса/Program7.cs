using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_7
{
    class Manager
    {
        private int age;     
        private string name; 

        public Manager(int initialAge, string initialName)
        {
            age = initialAge;
            name = initialName;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Имя: {name}, Возраст: {age}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Manager manager1 = new Manager(20, "Дамир");
            Manager manager2 = new Manager(18, "Сара");

            Console.WriteLine("Информация о первом менеджере:");
            manager1.DisplayInfo();

            Console.WriteLine("\nИнформация о втором  менеджере:");
            manager2.DisplayInfo();
        }
    }
}