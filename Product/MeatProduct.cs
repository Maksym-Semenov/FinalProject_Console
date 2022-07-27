using System;

namespace Product
{
    public abstract class MeatProduct : IProduct
    {
        public string name;
        public string description;
        public int id;
        public int price;
        public int quantity;
        public int Id { get { return id; } set { Id = value; } }
        public string Name { get { return name; } set { Name = value; } }
        public int Price { get { return price; } set { Price = value; } }
        public string Description { get { return description; } set { Description = value; } }
        public int Quantity { get { return quantity; } set { quantity = value; } }
        public virtual void Print()
        {
            Console.WriteLine();
        }
    }
}
