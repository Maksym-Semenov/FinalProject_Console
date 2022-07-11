using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliance
{
    internal interface IAppliance
    {
        string Name { get; }
        string company { get; }
        double price { get; }
    }
}
