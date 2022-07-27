using System;

namespace Product
{
    internal class Kefir : DairyProduct
    {
        private int quantity;
        public Kefir(int id, string name, int price, string description, int quantity)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.description = description;
            this.quantity = quantity;
        }
        public override void Print()
        {
            Console.WriteLine($"Kefir {Name} has price {Price} and id {Id}");
        }
    }
}
