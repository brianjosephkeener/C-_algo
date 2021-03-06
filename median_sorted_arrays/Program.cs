using System;
using System.Collections.Generic;
/*

Median of Sorted Arrays

Given two or more arrays that are sorted but not necessarily the same length, find the median value. 
For example, if given ​([1,5,9], [1,2,3,4,5,6])​, return ​4​.
If the number of values is even, return the average of the two middle values. if given ​([1,5,9], [1,2,3,4,5])​, return ​3.5​.

1, 1, 2, 3, 4, 5, 5, 6, 9 // returns 4

*/

namespace median_sorted_arrays
{
    class Program
    {

        static int medianSortedArrays(List<List<int>> arr)
        {
            List<int> result = new List<int>();
            foreach (List<int> itemTop in arr)
            {
                for (int i = 0; i < itemTop.Count; i++)
                {
                    result.Add(itemTop[i]);
                }
            }
            result.Sort();
            if(result.Count%2!=0)
            {
                return result[result.Count / 2];
            }
            else
            {
                return (result[(result.Count - 1) / 2] + result[result.Count / 2]) / 2;
            }
        }

        static void Main(string[] args)
        {
            List<int> testArr = new List<int> {1, 5, 9};
            List<int> testArr2 = new List<int> {1, 2, 3, 4, 5, 6};
            List<List<int>> list = new List<List<int>> {testArr, testArr2};
            Console.WriteLine(medianSortedArrays(list));
        }
    }
}
