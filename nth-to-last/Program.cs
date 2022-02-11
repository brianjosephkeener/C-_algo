using System;

namespace nth_to_last
{

    /*

    Nth-to-Last
    Return the element that is N-from-array’s-end.  

    */

    class Program
    {
        static int nAway(int[] arr, int aend)
        {
            return (arr[arr.Length - aend]);
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 5, 10, 18, 3, -2, 555, 1234, 5976};
            Console.WriteLine(nAway(arr, 4));
        }
    }
}
