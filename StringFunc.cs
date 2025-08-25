using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Delegate => when app run it transform to class
    // step 0 : Declare delegate to these function
    public delegate int StringFuncDelegate(string str);
    // New Delegate 
    // This reference from delegate can Refer to function or more than one function
    // Pointer to function
    // This Functions can be 'Class member method' or object member method
    // this delegate must have the same signature as the function it is pointing to
    
    internal class StringFunc
    {
        public static int CountOfUpperCase(string str)
        { 
            int count = 0;

            if (str is not null)
            {
                foreach (char ch in str)
                {
                    if (char.IsUpper(ch))
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public static int CountOfLowerCase(string str)
        {
            int count = 0;

            if (str is not null)
            {
                foreach (char ch in str)
                {
                    if (char.IsLower(ch))
                    {
                        count++;
                    }
                }
            }
            return count;
        }

    }
}
