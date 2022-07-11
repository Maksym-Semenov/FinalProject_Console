using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    internal class Student : IPerson
    {
        public string Name => throw new NotImplementedException();
        public string FirstName => throw new NotImplementedException();
        public int LastName => throw new NotImplementedException();
        int Group;
        string Speciality;
    }
}
