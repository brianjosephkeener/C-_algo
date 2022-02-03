using System;
using System.Collections.Generic;

namespace find_average
{
    class Program
    {
        static void Main(string[] args)
        {
            int FindAverage(List<int> arr)
            {
                int average = 0;

                foreach (int item in arr)
                {
                    average = average + item;
                }
                return average / arr.Count;
            }
            List<int> Testarr = new List<int>()
            {
                5, 5, 10, 100
            };
            Console.WriteLine($"The average of the given List/Array is {FindAverage(Testarr)}");
        }
    }
}
