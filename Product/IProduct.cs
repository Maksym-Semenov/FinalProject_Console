using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    internal interface IProduct
    {
        string name { get; }
        int price { get; }
    }
}
