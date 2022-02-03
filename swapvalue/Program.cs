using System;
using System.Collections.Generic;

// Write a function that will swap the first and last values of any given array. 
// The default minimum length of the array is 2. (e.g. [1,5,10,-2] will become [-2,5,10,1]).

namespace swapvalue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> swapVal(List<int> arr)
            {
                List<int> swaparr = new List<int>();
                
                swaparr = arr; 
                int temp = arr[0];
                swaparr[0] = arr[arr.Count - 1];
                swaparr[swaparr.Count - 1] = temp;
                return swaparr;
            }
            List<int> Testarr = new List<int>()
            {
                1, 100, 500, 0
            };
            foreach (int item in swapVal(Testarr))
            {
                Console.WriteLine(item);
            }
        }
    }
}
