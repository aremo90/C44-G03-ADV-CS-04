using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // New Delegate
    public delegate bool CompareDel(int a, int b);
    internal class SortingTypes
    {
        public static bool CompareGreater(int a, int b)
        {
            return a > b;
        }

        public static bool CompareLess(int a, int b)
        {
            return a < b;
        }


    }
}
