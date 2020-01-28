using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Square : Geometry
    {
        double a;
        
        public Square(double a)
        {
            this.A = a;
            this.Name = "Square";
        }

        public double A { get => a; set => a = value; }

        public override double CalculatePerimeter()
        {
            return 4 * A;
        }

        public override double CalculateArea()
        {
            return A * A;
        }

    }
}
