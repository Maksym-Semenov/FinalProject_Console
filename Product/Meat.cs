using System;

namespace Product
{
    internal class Meat : MeatProduct
    {
        private int quantity;
        public Meat(int id, string name, int price, string description, int quantity)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.description = description;
            this.quantity = quantity;
        }
        public override void Print()
        {
            Console.WriteLine($"Meat {Name} has price {Price}, description {description} and id {Id}");
        }
    }
}
