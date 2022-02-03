using System;
using System.Collections.Generic;

namespace Negatives
{
    class Program
    {
        static void Main(string[] args) // writing function to replace all negatives with a zero in a list
        {
            List<int> NoNeg(List<int> Arr)
            {
                for (int i = 0; i < Arr.Count; i++)
                {
                    if (Arr[i] < 0)
                    {
                        Arr[i] = 0;
                    }
                }
                return Arr;
            }
            List <int> testarray = new List<int>()
            {
                -1, 20, 5000, -30, 13
            };
            foreach (int item in NoNeg(testarray))
            {
                Console.WriteLine(item);
            }
        }
    }
}
