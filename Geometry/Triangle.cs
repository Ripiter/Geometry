using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Triangle : Geometry
    {
        double a, b, c;

        public Triangle(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
            this.Name = "Triangle";
        }

        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }
        public double C { get => c; set => c = value; }

        public override double CalculateArea()
        {
            return .5 * (A * B);
        }

        public override double CalculatePerimeter()
        {
            return A + B + C;
        }
    }
}
