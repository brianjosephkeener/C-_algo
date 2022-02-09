using System;
using System.Collections.Generic;

/*

RemoveAt

Given an array and an index into the array,
remove and return the array value at that index.

*/

namespace RemoveAt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> array = new List<string>
                {
                    "hello",
                    "world",
                    "create",
                    "program"
                };
            array.RemoveAt(0);
            foreach (string item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
