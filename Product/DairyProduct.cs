using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    public abstract class DairyProduct : IProduct
    {
        public string name;
        public string description;
        public int id;
        public int price;
        public int Id { get { return id; } set { Id = value; } }
        public string Name { get { return name; } set { Name = value; } }
        public int Price { get { return price; } set { Price = value; } }
        public string Description { get { return description; } set { Description = value; } }
        public virtual void Print()
        {
            Console.WriteLine();
        }
    }
}
