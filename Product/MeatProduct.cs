using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;

namespace Product
{
   
    [Serializable]
    [DataContract]
    public abstract class MeatProduct : IProduct
    {
        public int id;
        public string type;
        public string name;
        public int price;
        public string description;
        public int quantity;
        [DataMember]
        [XmlAttribute]
        public int Id { get { return id; } set { Id = value; } }
        [DataMember]
        [XmlAttribute]
        public string Type { get { return type; } set { Type = value; } }
        [DataMember]
        [XmlAttribute]
        public string Name { get { return name; } set { Name = value; } }
        [DataMember]
        [XmlAttribute]
        public int Price { get { return price; } set { Price = value; } }
        [DataMember]
        [XmlAttribute]
        public string Description { get { return description; } set { Description = value; } }
        [DataMember]
        [XmlAttribute]
        public int Quantity { get { return quantity; } set { quantity = value; } }
        public MeatProduct()
        {
        }
        public virtual void Print()
        {
            Console.WriteLine();
        }
    }
}
