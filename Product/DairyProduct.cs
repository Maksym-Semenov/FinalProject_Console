using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;

namespace Product
{
    [XmlInclude(typeof(Milk))]
    [XmlInclude(typeof(Kefir))]
    public abstract class DairyProduct : IProduct
    {
        public int id;
        public string name;
        public int price;
        public string description;
        public int quantity;
        [XmlAttribute]
        [DataMember]
        public int Id { get { return this.id; } set { Id = value; } }
        [XmlAttribute]
        [DataMember]
        public string Name { get { return this.name; } set { Name = value; } }
        [XmlAttribute]
        [DataMember]
        public int Price { get { return this.price; } set { Price = value; } }
        [XmlAttribute]
        [DataMember]
        public string Description { get { return this.description; } set { Description = value; } }
        [XmlAttribute]
        [DataMember]
        public int Quantity { get { return this.quantity; } set { Quantity = value; } }
        public DairyProduct()
        {

        }
        public virtual void Print()
        {
            Console.WriteLine();
        }
    }
}
