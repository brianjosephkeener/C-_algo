using System;
using System.Linq;

/*

Nth-Largest

Given an array, return the Nth-largest element: there should be (N - 1) elements that are larger.

*/

namespace nth_largest_in_array
{
    class Program
    {
        static int NthElement(int[] arr, int nth)
        {
            var sortedArray = arr.OrderBy(num => num);
            var QS = (from num in arr
                      orderby num
                      select num).ToArray();
            Console.WriteLine(QS[QS.Length - nth]);
            return QS[QS.Length - nth];
        }
        static void Main(string[] args)
        {
            int[] testArray = {1, 5, 3, 100, 500, 5, 2, 18, 11};
            NthElement(testArray, 3);
        }
    }
}
