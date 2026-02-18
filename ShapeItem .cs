using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solve_task_8
{
    class ShapeItem : IComparable<ShapeItem>
    {
        public string Name { get; set; }
        public double Area { get; set; }

        public ShapeItem(string name, double area) { Name = name; Area = area; }
        public int CompareTo(ShapeItem other) => Area.CompareTo(other.Area);
        public override string ToString() => $"{Name}: {Area:F2}";
    }
}
