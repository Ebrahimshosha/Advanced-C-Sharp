using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_3_Delegate
{

    // Generic Method
    //public delegate bool CompareFuncDelegate<T1>(T1 A, T1 B);

    //public delegate bool CompareFuncDelegate<T1,T2>(T1 A, T2 B);

    //public delegate TResult CompareFuncDelegate<in T1, in T2, out TResult>(T1 A, T2 B);


    internal class SortingAlgorithm<T>
    {
        public static void Swap(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }

        public static void BubbleSort(T[] arr, Func<T,T,bool> compareFuncDelegate)
        {
            if (arr is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                    for (int j = 0; j < arr.Length - i - 1; j++) 
                        if (compareFuncDelegate.Invoke(arr[j], arr[j + 1]))
                            Swap(ref arr[j], ref arr[j + 1]);
            }
        }
    }

    class CompareFunctions
    {
        public static bool CompareGrt(int x, int y) { return x > y; }  //  Sort Asc
        public static bool CompareLess(int x, int y) { return x < y; } // Sort Desc

        public static bool SortAsc(string x, string y) { return x?.Length > y?.Length; } // Sort Asc
        public static bool SortDesc(string x, string y) { return x?.Length < y?.Length; } // Sort Desc

    }
}
