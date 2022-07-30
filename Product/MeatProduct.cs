using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;

namespace Product
{
    [DataContract]
    public abstract class MeatProduct : IProduct
    {
        public int id;
        public string name;
        public int price;
        public string description;
        public int quantity;
        [DataMember]
        public int Id { get { return this.id; } set { this.Id = value; } }
        [DataMember]
        public string Name { get { return this.name; } set { this.Name = value; } }
        [DataMember]
        public int Price { get { return this.price; } set { this.Price = value; } }
        [DataMember]
        public string Description { get { return this.description; } set { this.Description = value; } }
        [DataMember]
        public int Quantity { get { return this.quantity; } set { this.Quantity = value; } }
        public MeatProduct()
        {

        }
        public virtual void Print()
        {
            Console.WriteLine();
        }
    }
}
