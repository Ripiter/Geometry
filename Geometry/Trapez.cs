using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Trapez : Parallelogram
    {
        double c, d;
        public Trapez(double a, double b, double c, double d) : base(a, b)
        {
            this.C = c;
            this.D = d;
            this.Name = "Trapez";
        }

        public double C { get => c; set => c = value; }
        public double D { get => d; set => d = value; }

        public override double CalculatePerimeter()
        {
            return A + B + C + D;
        }

        public override double CalculateArea()
        {
            double s = (A + B - C + D) / 2;

            double t = s * (s - A + C) * (s - B) * (s - D);

            double th = (2 / (A - C));

            double h = th * Math.Sqrt(t);

            double area = 0.5 * (A + C) * h;

            return area;
        }
    }
}
