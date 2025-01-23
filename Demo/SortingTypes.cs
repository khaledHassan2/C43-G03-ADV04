using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class SortingTypes
    {
        public static bool SortAsc(string x,string y) { return x?.Length > y?.Length; }
        public static bool SortDes(string x, string y) { return x?.Length < y?.Length; }

        public static bool ComperGrt(int x, int y) { return x > y; } // Sort Asc
        public static bool ComperLess(int x, int y){return x < y;} // Sort Dec


    }
}
