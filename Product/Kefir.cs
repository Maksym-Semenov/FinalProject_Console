using System;

namespace Product
{
    internal class Kefir : DairyProduct, IComparable<Kefir>
    {
        public Kefir(int id, string name, int price, string description, int quantity)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.description = description;
            this.quantity = quantity;
        }
        public int CompareTo(Kefir other)
        {
            return id.CompareTo(id);
        }
        public override void Print()
        {
            Console.WriteLine($"Kefir {Name} has price {Price} and id {Id}. Quantity = {quantity}");
        }
    }
}
