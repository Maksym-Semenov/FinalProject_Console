using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;

namespace Product
{
    [XmlInclude(typeof(Meat))]
    [XmlInclude(typeof(Sausage))]
    public abstract class MeatProduct : IProduct
    {
        public int id;
        public string name;
        public int price;
        public string description;
        public int quantity;
        [XmlAttribute]
        public int Id { get { return this.id; } set { this.Id = value; } }
        [XmlAttribute]
        public string Name { get { return this.name; } set { this.Name = value; } }
        [XmlAttribute]
        public int Price { get { return this.price; } set { this.Price = value; } }
        [XmlAttribute]
        public string Description { get { return this.description; } set { this.Description = value; } }
        [XmlAttribute]
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
