using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solve_task_8
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Book() : this("Unknown", "Unknown") { }
        public Book(string title) : this(title, "Unknown") { }
        public Book(string title, string author) { Title = title; Author = author; }

        public override string ToString() => $"\"{Title}\" by {Author}";
    }
}
