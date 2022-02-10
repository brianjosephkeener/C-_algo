using System;
using System.Collections.Generic;

/*

Rotate Array

Implement ​rotateArr (arr, shiftBy)​ that accepts array and offset. Shift arr’s values ​to the right​ by that amount. 
‘Wrap-around’ any values that shift off array’s end to the other side, so that no data is lost. 
Operate in-place: given ([1,2,3],1)​, change the array to [​ 3,1,2]​.

*/

namespace rotate_array
{
    class Program
    {
        static void RArray(List<int> arr, int ramount)
        {
            List<int> rarr = new List<int>();
            for (int i = 0; i < arr.Count; i++)
            {
                if(ramount > i)
                {
                    rarr.Add(arr[arr.Count-ramount+i]);
                }
                else
                {
                    rarr.Add(arr[i-ramount]);
                }
            }
            foreach (int item in rarr)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            List<int> testArr = new List<int>{
                1, 2, 3
            };
            RArray(testArr, 1);
        }
    }
}
