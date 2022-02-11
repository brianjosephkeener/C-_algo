using System;
using System.Linq;

/*

Second-Largest

Return the second-largest element of an array.

*/

namespace _2nd_Largest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = {1, 5, 3, 100, 500, 5, 2, 18, 11};
            var sortedArray = testArray.OrderBy(num => num);

            var QS = (from num in testArray
                      orderby num
                      select num).ToArray();
            Console.WriteLine(QS[QS.Length - 2]);
        }
    }
}
