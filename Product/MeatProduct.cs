using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;

namespace Product
{
    public abstract class MeatProduct : IProduct
    {
        public int id;
        public string name;
        public int price;
        public string description;
        public int quantity;

        public int Id { get { return this.id; } set { this.id = value; } }

        public string Name { get { return this.name; } set { this.name = value; } }

        public int Price { get { return this.price; } set { this.price = value; } }

        public string Description { get { return this.description; } set { this.description = value; } }

        public int Quantity { get { return this.quantity; } set { this.quantity = value; } }


        public MeatProduct(int id, string name, int price, string description, int quantity)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.description = description;
            this.quantity = quantity;
        }

        public virtual void Print()
        {
            Console.WriteLine();
        }
    }
}
