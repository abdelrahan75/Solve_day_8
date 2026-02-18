using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solve_task_8
{
    internal interface IShapeSeries
    {
        public int CurrentShapeArea { get; set; }
        void GetNextArea();

        void ResetSeries();
    }
}
