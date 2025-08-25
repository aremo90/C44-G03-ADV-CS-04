using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate bool ConditionDelegate(int number);
    //public delegate TResult ConditionDelegate<T , TResult>(T number);
    internal class CheckNumber
    {
        public static bool IsOdd(int number)
        {
            return number % 2 == 1;
        }
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
}
