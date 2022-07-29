using System;

namespace Product
{
    [Serializable]
    public class Sausage : MeatProduct, IComparable<Sausage>
    {
        public Sausage()
        {

        }
        public Sausage(int id, string name, int price, string description, int quantity)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.description = description;
            this.quantity = quantity;
        }

        public int CompareTo(Sausage other)
        {
            return this.id.CompareTo(this.id);
        }

        public override void Print()
        {
            Console.WriteLine($"Sausage {this.name} has price {this.price} and id {this.id}. Quantity = {this.quantity}.");
        }
    }
}
