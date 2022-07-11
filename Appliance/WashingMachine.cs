using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliance
{
    internal class WashingMachine : IAppliance
    {
        public string Name => throw new NotImplementedException();
        public string company => throw new NotImplementedException();
        public double price => throw new NotImplementedException();
        int numberProgram;
        int volume;
    }
}
