using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Program
    {
        static void Main(string[] args)
        {
            Geometry[] geoDude = {
                new Rectangle(3,5),
                new Square(5,5),
                new Trapez(10, 9, 8, 9),
                new Triangle(10, 6, 10)
            };

            foreach (Geometry geometry in geoDude)
            {
                Console.WriteLine(geometry.Name  + "\n" +
                                  geometry.CalculateArea() + "\n" +
                                  geometry.CalculatePerimeter());
            }


            Console.ReadKey();
        }
    }
}
