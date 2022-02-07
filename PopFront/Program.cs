using System;
using System.Collections.Generic;

/*

PopFront

Given an array, remove and return the value at
the beginning of the array. 

*/

namespace PopFront
{
    class Program
    {
        static void Main(string[] args)
        {
         string PopFront(List<string> arr)
        {
            string endVal = arr[(arr.Count-1)];
            arr.RemoveAt(arr.Count-1);
            return endVal;
        }
            List<string> Array = new List<string>{
                "foo",
                "bar"
            };
            foreach (string item in Array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("removed value: " + PopFront(Array));
        }
    }
}
