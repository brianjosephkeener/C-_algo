using System;

/*

Mode of Array

Create a function that, given an array, returns the most frequent value in the array.

[1, 1, 1, 4, 3, 5] returns 1

*/

namespace Mode_of_Array
{
    class Program
    {
        static int Mode(int[] arr)
        {
            int mfv = 0;
            int gcount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int icount = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if(arr[i] == arr[j])
                    {
                        icount++;
                    }
                }
                if(icount > gcount)
                {
                    gcount = icount;
                    mfv = arr[i];
                }
            }
            return mfv;
        }
        static void Main(string[] args)
        {
            int[] testArr = new int[]{1, 1, 1, 4, 3, 5};
            int[] testArr2 = new int[]{2, 4, 5, 4, 3, 5, 6, 6, 6};
            Console.WriteLine(Mode(testArr)); // returns 1
            Console.WriteLine(Mode(testArr2)); // returns 6

        }
    }
}
