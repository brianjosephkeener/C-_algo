using System;
using System.Collections.Generic;

namespace _1_to_255
{
    class Program
    {
        static void Main(string[] args)
        {
            // program loops through 1 to 255 adding each number to a list
            List<int> Arr = new List<int>();
            for (int i = 1; i < 256; i++)
            {
                Arr.Add(i);
                Console.WriteLine(Arr[i-1]);
            }
        }
    }
}
