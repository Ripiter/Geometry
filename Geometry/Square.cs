using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Square : Geometry
    {
        double a, b;
        
        public Square(double a, double b)
        {
            this.A = a;
            this.B = b;
            this.Name = "Square";
        }

        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }

        public override double CalculatePerimeter()
        {
            return (2 * a) + (2 * b);
        }

        public override double CalculateArea()
        {
            return a * a;
        }

    }
}
