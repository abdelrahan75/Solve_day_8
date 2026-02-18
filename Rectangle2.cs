using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solve_task_8
{
    class Rectangle2 : GeometricShape
    {
        public Rectangle2(double w, double h) { Dimension1 = w; Dimension2 = h; }
        public override double CalculateArea() => Dimension1 * Dimension2;
        public override double Perimeter => 2 * (Dimension1 + Dimension2);
    }
}
