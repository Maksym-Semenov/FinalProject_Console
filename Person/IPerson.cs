using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    internal interface IPerson
    {
        string Name { get; }
        string FirstName { get; }
        int LastName { get; }
    }
}
