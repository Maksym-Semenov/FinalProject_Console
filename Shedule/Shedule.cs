using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shedule
{
    internal class Shedule
    {
        DateTime date = new DateTime();
        Dictionary<int, string> DayShedule = new Dictionary<int, string>()
        {
            { 10, "Brush teeth" },
            { 15, "Take a shower" },
            { 30, "Physical jerks" }
        };
    }
}
