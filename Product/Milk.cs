using System;
using System.Runtime.Serialization;

namespace Product
{
    [DataContract]
    public class Milk : DairyProduct, IComparable<Milk>
    {
        public int fatContent;

        [DataMember]
        public int Id { get { return this.id; } set { Id = value; } }

        [DataMember]
        public string Name { get { return this.name; } set { Name = value; } }

        [DataMember]
        public int Price { get { return this.price; } set { Price = value; } }

        [DataMember]
        public string Description { get { return this.description; } set { Description = value; } }

        [DataMember]
        public int Quantity { get { return this.quantity; } set { Quantity = value; } }

        [DataMember]
        public int FatContent { get { return this.fatContent; } set { this.fatContent = value; } }

        public Milk(int id, string name, int price, string description, int quantity, int fatContent)
                 : base(id, name, price, description, quantity)
        {
            this.fatContent = fatContent;
        }

        public int CompareTo(Milk other)
        {
            return this.Id.CompareTo(this.Id);
        }

        public override void Print()
        {
            Console.WriteLine($"Product {GetType().Name}, Id = {this.Id} name = {this.Name}, Price = {this.Price}," +
                              $" Description = {this.Description}, Quantity = {this.Quantity}, fat content = {this.fatContent}");
        }
    }
}
