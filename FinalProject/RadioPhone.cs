using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    internal class RadioPhone : IPhone
    {
        public string name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string company { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double price { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        double radius;
        bool isHasAutoanswer = false;
    }
}
