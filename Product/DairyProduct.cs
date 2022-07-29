using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;

namespace Product
{
    [DataContract]
    public abstract class DairyProduct : IProduct
    {
        public int id;
        public string name;
        public int price;
        public string description;
        public int quantity;

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

        public virtual void Print()
        {
            Console.WriteLine();
        }
    }
}
