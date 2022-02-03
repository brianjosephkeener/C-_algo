using System;
using System.Collections.Generic;

namespace Find_Max
{
    class Program
    {
        static void Main(string[] args)
        {
        
        int MaxinList(List<int> arr)
        {
            int max = int.MinValue;
            foreach (var item in arr)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            return max;
        }

        List<int> Testarr = new List<int>()
        {
            1, 10, 55, 30, 200, 100
        };

            Console.WriteLine(MaxinList(Testarr));
        }
    }
}
