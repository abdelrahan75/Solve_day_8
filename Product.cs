using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solve_task_8
{
    internal class Product : IComparable<Product>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; } 

        public Product (int I, string n, int p)
        {
            ID = I;
            Name = n;
            Price = p;
        }


        public  int CompareTo(Product obj)
        {
          return  Price.CompareTo(obj.Price);
        }
        public override string ToString()
        {
          return  $"{Name} - ${Price}";
        }

    }
}
