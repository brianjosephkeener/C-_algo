using System;
using System.Collections.Generic;

/*

Reverse Array

Given a numerical array, reverse the order of the
values. The reversed array should have the same
length, with existing elements moved to other
indices so that the order of elements is reversed

*/

namespace Reverse_Array
{
    class Program
    {
        static List<string> RArray(List<string> arr)
        {
            List<string> rarr = new List<string>();
            for (int i = arr.Count -1 ; i >= 0; i--)
            {
                rarr.Add(arr[i]);
            }
            return rarr;
        }
        static void Main(string[] args)
        {
            List<string> testArray = new List<string>{
                "hello",
                "world",
                "this",
                "is",
                "a",
                "test"
            };
            foreach (string item in RArray(testArray))
            {
                Console.WriteLine(item);
            }
        }
    }
}
