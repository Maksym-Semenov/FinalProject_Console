using System;

namespace Product
{
    internal class Meat : MeatProduct, IComparable<Meat>
    {
        public Meat(int id, string type, string name, int price, string description, int quantity)
        {
            this.id = id;
            this.type = type;
            this.name = name;
            this.price = price;
            this.description = description;
            this.quantity = quantity;
        }
        public int CompareTo(Meat other)
        {
            return id.CompareTo(id);
        }
        public override void Print()
        {
            Console.WriteLine($"Meat {Name} has price {Price}, description {description} and id {Id}. Quantity = {quantity}");
        }
    }
}
