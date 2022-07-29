using System;

namespace Product
{
    [Serializable]
    public class Kefir : DairyProduct, IComparable<Kefir>
    {
        public Kefir()
        {

        }
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
            return this.id.CompareTo(this.id);
        }

        public override void Print()
        {
            Console.WriteLine($"Kefir {this.name} has price {this.price} and id {this.id}. Quantity = {this.quantity}.");
        }
    }
}
