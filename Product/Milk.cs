using System;

namespace Product
{
    [Serializable]
    public class Milk : DairyProduct, IComparable<Milk>
    {
        public Milk()
        {

        }
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
            return this.id.CompareTo(this.id);
        }

        public override void Print()
        {
            Console.WriteLine($"Milk {this.name} has price {this.price} and id {this.id}. Quantity = {this.quantity}.");
        }
    }
}
