using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_7
{
    internal class Program
    {
        class Point3D
        {
            public int x;
            public int y;
            public int z;

            public void Show()
            {
                Console.WriteLine($"x: {x}, y: {y}, z: {z}");
            }
        }

        static void Main(string[] args)
        {
            Point3D point3D = new Point3D();
            point3D.x = 1;
            point3D.y = 2;
            point3D.z = 3;
            point3D.Show();
        }
    }
}
