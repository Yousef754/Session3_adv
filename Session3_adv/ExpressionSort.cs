using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3_adv
{
    internal class ExpressionSort
    {

        public static bool GreaterThan(int x, int y) {return x > y;}
        public static bool LessThan(int x, int y) { return x < y; }

        public static bool Ascending(string v1, string v2)
        {
            return v1.Length > v2.Length;
        }
        public static bool Descending(string v1, string v2)
        {
            return v1.Length < v2.Length;
        }
    }

}

