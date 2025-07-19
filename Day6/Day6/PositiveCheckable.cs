using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class PositiveCheckable : ICheckable
    {
        public bool Check(int item)
        {
           return item > 0;
        }
    }
}
