using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solve_task_8
{
    internal class Student
    {
        public int Id {  get; set; }
        public string Name { get; set; }

        public double Grade {  get; set; }

        public Student(int i, string n, double g)
        {
            Id = i;
            Name = n;
            Grade = g;
        }
        public Student(Student other)
        { Id = other.Id; Name = other.Name; Grade = other.Grade; }

        public override string ToString() => $"[{Id}] {Name} - {Grade}";
    }
}
