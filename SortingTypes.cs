using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // New Delegate
    //public delegate bool CompareDel(int a, int b);
    public delegate TResult CompareDel<in T , out TResult>(T a, T b);
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


        // sort string 
        public static bool CompareStringGreater(string a, string b)
        {
            return a.Length > b.Length;
        }
        public static bool CompareStringLess(string a, string b)
        {
            return a.Length < b.Length;
        }

    }
}
