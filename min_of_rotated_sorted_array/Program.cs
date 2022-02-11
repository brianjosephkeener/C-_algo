using System;
using System.Collections.Generic;

/*

Min Of Sorted-Rotated

You will be given a numerical array that has first been sorted, then rotated by an unknown amount. 
Find and return the minimum value in that array.

*/

namespace min_of_rotated_sorted_array
{
    class Program
    {
        static int MRSArray(List<int> arr)
        {
            int min = Int32.MaxValue;
            for (int i = 0; i < arr.Count; i++)
            {
                if(min > arr[i])
                {
                    min = arr[i];
                }
            }
            return min;
        }
        static void Main(string[] args)
        {
            List<int> testArray = new List<int>{
                1, 5, 100, 500, -3, 15, 1
            };
            Console.WriteLine(MRSArray(testArray));
        }
    }
}
