using System;
using System.Collections.Generic;
/*

rBinarySearch
Write a recursive function that, given a sorted array and a value, determines whether the value is found within the array and the index where to find it. 
For example, rBinarySearch([1,3,5,6], 4) = -1; rBinarySearch([4,5,6,8,12], 5) = 1.

*/

namespace rBinarySearch
{
    class Program
    {
    static object rBSearch(List<int> arr, int skey, int last, int first = 0)
        {
            int mid = (first+last) / 2;
            if (arr[mid] == skey)
            {
                return mid;
            }
            else if (first >= last)
            {
                return "value not found";
            }
            else if (skey < arr[mid])
            {
                last = mid - 1;
                return rBSearch(arr, skey, last, first);
            }
            else
            {
                return rBSearch(arr, skey, last, mid);
            }
        }
        static void Main(string[] args)
        {
            List<int> testArr = new List<int>{
                1, 2, 5, 80, 100, 1000, 50000, 9999999
            };
            Console.WriteLine(rBSearch(testArr, 1000, testArr.Count-1));
            Console.WriteLine(rBSearch(testArr, 1234, testArr.Count-1));
        }
    }
}
