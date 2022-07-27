using System;

namespace Product
{
    internal class Sausage : MeatProduct
    {
        private int quantity;
        public Sausage(int id, string name, int price, string description, int quantity)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.description = description;
            this.quantity = quantity;
        }
        public override void Print()
        {
            Console.WriteLine($"Sausage {Name} has price {Price} and id {Id}");
        }
    }
}
