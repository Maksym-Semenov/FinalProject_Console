using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    public interface IProduct
    {
        int Id { get; set; }
        string Name { get; set; }
        int Price { get; set; }
        void Print();
    }
}
