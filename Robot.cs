using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solve_task_8
{
    internal class Robot : IWalkable
    {
        public void Walk()
        {
            Console.WriteLine("is walk");
        }
        void IWalkable.Walk()
        {
            Console.WriteLine("Iwalkable,  is walk");
        }
    }
}
