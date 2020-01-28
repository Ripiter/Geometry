using System;

namespace Geometry
{
    class Parallelogram : Rectangle
    {
        double v;

        public Parallelogram(double a, double b, double v) : base(a, b)
        {
            this.V = v;
            this.Name = "Parallelogram";
        }

        public Parallelogram(double a, double b) : base(a, b)
        {

        }
        public double V { get => v; set => v = value; }
        public override double CalculatePerimeter()
        {
            return (2 * A) + (2 * B);
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
