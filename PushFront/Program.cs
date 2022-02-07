using System;
using System.Collections.Generic;

namespace PushFront
{

/*

PushFront

Given an array and an additional value, insert this
value at the beginning of the array.

*/
    class Program
    {

        public static List<string> PushingP(List<string> arr)
        {
            return arr;
        }
        static void Main(string[] args)
        {
            List<int> Array = new List<int>{
                12,
                15,
                100
            };
            Array.Insert(0, 1);
            foreach (int item in Array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
