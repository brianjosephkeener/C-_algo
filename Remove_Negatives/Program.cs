using System;
using System.Collections.Generic;

/*

Remove Negatives

Implement a function removeNegatives()​ that
accepts an array and removes any values that
are less than zero.


*/

namespace Remove_Negatives
{
    class Program
    {
        static List <int> RNegatives(List<int> arr)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                if(arr[i] < 0)
                {
                    arr.Remove(arr[i]);
                }
            }
            return arr;
        }
        static void Main(string[] args)
        {
            List<int> TestArray = new List<int>{
                1,
                5,
                10,
                -3,
                0,
                99
            };
            foreach (int item in RNegatives(TestArray))
            {
                Console.WriteLine(item);
            }
        }
    }
}
