using System;
using System.Collections.Generic;

/*

InsertAt

Given an array, index, and additional value, insert
the value into the array at the given index. 


*/

namespace InsertAt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Array = new List<int>{
            100,
            5,
            1500,
            93,
            1
            };
            Array.Insert(2, 1234);
            foreach (int item in Array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
