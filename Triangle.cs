using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solve_task_8
{
    class Triangle : GeometricShape
    {
        public Triangle(double base_, double height) { Dimension1 = base_; Dimension2 = height; }
        public override double CalculateArea() => 0.5 * Dimension1 * Dimension2;
        public override double Perimeter => Dimension1 + Dimension2 + Math.Sqrt(Dimension1 * Dimension1 + Dimension2 * Dimension2);
    }
}
