using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solve_task_8
{
    internal abstract class Shape
    {
        public abstract double Get_area();

        public void Display()
        {
            Console.WriteLine($"area is {Get_area()}");
        }
        
    }
}
