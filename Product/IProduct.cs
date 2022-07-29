using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Product
{
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
