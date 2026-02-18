using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solve_task_8
{
    internal class Rectangle : Shape 
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width; Height = height;
        }
        public override double Get_area()
        {
            return Width * Height;
        }

        public int CompareTo(Rectangle other) => Get_area().CompareTo(other.Get_area());

    }
}
