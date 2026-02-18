using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solve_task_8
{
    internal class Circle : Shape
    {
        public double Rad {  get; set; }
        const double Pay = 3.14;

        public Circle(double R)
        {
            Rad = R;
        }

        public override double Get_area()
        {
            return Rad * Pay;
        }
    }
}
