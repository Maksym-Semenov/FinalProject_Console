using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    internal abstract class DairyProduct : IProduct
    {
        public string name => throw new NotImplementedException();
        public int price => throw new NotImplementedException();
    }
}
