using System;

namespace Product
{
    internal class Milk : DairyProduct, IComparable<Milk>
    {
        public Milk(int id, string name, int price, string description, int quantity)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.description = description;
            this.quantity = quantity;
        }
        public int CompareTo(Milk other)
        {
            return id.CompareTo(id);
        }
        public override void Print()
        {
            Console.WriteLine($"Milk {Name} has price {Price} and id {Id}. Quantity = {quantity}");
        }
    }
}
