using System;

namespace Geometry
{
    class Parallelogram : Square
    {
        double v, b;
        public Parallelogram(double a, double b, double v) : base(a)
        {
            this.V = v;
            this.B = b;
            this.Name = "Parallelogram";
        }
        
        public double V { get => v; set => v = value; }
        public double B { get => b; set => b = value; }

        public override double CalculatePerimeter()
        {
            return (2 * A) + (2 * b);
        }

        public override double CalculateArea()
        {
            double angle = Math.PI * v / 180.0;
            double sinAngle = Math.Sin(angle);

            double ret = A * B * sinAngle;

            return ret;
        }
    }
}
