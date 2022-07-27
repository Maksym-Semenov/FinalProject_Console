using System;

namespace Product
{
    internal class Milk : DairyProduct
    {
        private int quantity;
        public Milk(int id, string name, int price, string description, int quantity)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.description = description;
            this.quantity = quantity;
        }
        public override void Print()
        {
            Console.WriteLine($"Milk {Name} has price {Price} and id {Id}");
        }
    }
}
