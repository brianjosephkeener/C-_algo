using System;
using System.Collections.Generic;

namespace array_odd
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that would return an array of all the odd numbers between 1 to 50.
            List<int> OddArray50()
            {
                List<int> Arr = new List<int>();
                for (int i = 1; i < 51; i=i+2)
                {
                    Arr.Add(i);
                }
                return Arr;
            }
            foreach(int item in OddArray50())
            {
                if(item == OddArray50()[0] && OddArray50().Count > 1)
                {
                    Console.WriteLine($"[{item} ");
                    continue;
                }
                if(item == OddArray50()[OddArray50().Count - 1])
                {
                    Console.WriteLine($"{item}]");
                    break;
                }
                Console.WriteLine($"{item} ");
            };
        }
    }
}
