using System;
using System.Runtime.Serialization;

namespace Product
{
    [DataContract]
    public class Sausage : MeatProduct, IComparable<Sausage>
    {
        private string typeOfMeat;

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
        public string TypeOfMeat { get { return this.typeOfMeat; } set { TypeOfMeat = value; } }

        public Sausage(int id, string name, int price, string description, int quantity, string typeOfMeat)
                 : base(id, name, price, description, quantity)
        {
            this.typeOfMeat = typeOfMeat;
        }

        public int CompareTo(Sausage other)
        {
            return this.Id.CompareTo(this.Id);
        }

        public override void Print()
        {
            Console.WriteLine($"Product {GetType().Name}, Id = {this.Id} name = {this.Name}, Price = {this.Price}," +
                              $" Description = {this.Description}, Quantity = {this.Quantity}, Type of meat = {this.TypeOfMeat}");
        }
    }
}
