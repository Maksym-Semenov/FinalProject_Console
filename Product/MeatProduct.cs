using System;

namespace Product
{
    public abstract class MeatProduct : IProduct
    {
        public int id;
        public string type;
        public string name;
        public int price;
        public string description;
        public int quantity;
        public int Id { get { return id; } set { Id = value; } }
        public string Type { get { return type; } set { Type = value; } }
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
