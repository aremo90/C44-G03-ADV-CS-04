using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    internal class Helper <T>
    {
        private static void Swap(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        // Sort Asscending
        public static void BuubleSort(T[] arr , CompareDel<T , bool> CompareTypeDel)
        {
            
            if (arr is not null )
            {
                
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    for (int j = 0; j < arr.Length - 1 - i; j++)
                    {
                        if (CompareTypeDel.Invoke(arr[j] , arr[j+1]))
                            Swap(ref arr[j] , ref arr[j+1]);
                    }
                }
            }
        }


        //public static void SortDesc(int[] arr)
        //{
            
        //    if (arr is not null)
        //    {

        //        for (int i = 0; i < arr.Length - 1; i++)
        //        {
        //            for (int j = 0; j < arr.Length - 1 - i; j++)
        //            {
        //                if (arr[j] > arr[j + 1])
        //                {
        //                    Swap(ref arr[j], ref arr[j + 1]);
        //                }
        //            }
        //        }
        //    }
        //}



    }
}
