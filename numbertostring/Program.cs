using System;
using System.Collections.Generic;

// Write a function that takes an array of numbers and replaces any negative values within the array with a string. 
// For example if array = [-1,-3,2], your function will return ['string','string',2].

namespace numbertostring
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> negtostring(List<object> arr)
            {
                for (int i = 0; i < arr.Count; i++)
                {
                    if((int)arr[i] < 0)
                    {
                        arr[i] = "negative!";
                    }
                }
                return arr;
            }
            List<object> Testarr = new List<object>()
            {
                1, -10, 5, 3, -500
            };
            foreach (var item in negtostring(Testarr))
            {
                Console.WriteLine(item);
            }
        }
    }
}
