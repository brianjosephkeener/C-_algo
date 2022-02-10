using System;
using System.Collections.Generic;

/*

Binary Search

Given a sorted array and a value, return whether that value is present in the array. Do not sequentially iterate the entire array. 
Instead, ‘divide and conquer’, taking advantage of the fact that the array is sorted.

*/

namespace binary_search
{
    class Program
    {
        static object BSearch(List<int> arr, int skey)
        {
            int min = 0;
            int max = arr.Count - 1;
            while(min <= max)
            {
                int mid = (min + max) / 2;
                if (skey == arr[mid])
                {
                    return ++mid;
                }
                else if (skey < arr[mid])
                {
                    max = mid - 1;
                }
                else 
                {
                    min = mid + 1;
                }
            }
            return "value not found";
        }
        static void Main(string[] args)
        {
            List<int> testArr = new List<int>{
                1, 2, 5, 80, 100, 1000, 50000, 9999999
            };
            Console.WriteLine(BSearch(testArr, 1000));
            Console.WriteLine(BSearch(testArr, 2));
            Console.WriteLine(BSearch(testArr, 1234));
        }
    }
}
