using System;

namespace Geometry
{
    class Parallelogram : Square
    {
        double v;
        public Parallelogram(double a, double b, double v) : base(a, b)
        {
            this.V = v;
            this.Name = "Parallelogram";
        }
        
        public double V { get => v; set => v = value; }

      
        public override double CalculateArea()
        {
            double angle = Math.PI * v / 180.0;
            double sinAngle = Math.Sin(angle);

            double ret = A * B * sinAngle;

            return ret;
        }
    }
}
