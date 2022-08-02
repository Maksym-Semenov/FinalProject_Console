using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Product
{
    [JsonConverter(typeof(List<IProduct>))]
    public interface IProduct
    {
        int Id { get; set; }

        string Name { get; set; }

        int Price { get; set; }

        string Description { get; set; }

        int Quantity { get; set; }

        void Print();
    }
}
