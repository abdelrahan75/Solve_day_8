using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solve_task_8
{
    internal class CircleSeries : IShapeSeries
    {
        private int _radius = 0;

        public int CurrentShapeArea { get; set; }

        public void GetNextArea()
        {
            _radius++;
            CurrentShapeArea = (int)(Math.PI * _radius * _radius);
        }

        public void ResetSeries()
        {
            _radius = 0;
            CurrentShapeArea = 0;
        }
    }
}
    