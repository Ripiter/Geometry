using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Rectangle : Geometry
    {
        double a, b;

        public Rectangle(double a, double b)
        {
            this.A = a;
            this.B = b;
            this.Name = "Reckangle";
        }

        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }

        public override double CalculateArea()
        {
            return a * b;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (a + b);
        }
    }
}
