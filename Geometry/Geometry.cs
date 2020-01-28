using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    abstract class Geometry
    {
        public abstract double CalculatePerimeter();

        public abstract double CalculateArea();

        public string Name;
    }
}
