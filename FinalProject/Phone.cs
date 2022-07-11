using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    internal interface IPhone
    {
        string name { get; set; }
        string company { get; set; }
        double price { get; set; }
    }
}
