using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class Helper
    {
        public int ID { get; set; }
        public static bool IsOdd(int item)
        {
            return item % 2 != 0;
        }
        public  bool IsNagative(int item)
        {
            return item < 0;
        }
    }
}
