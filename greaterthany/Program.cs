using System;
using System.Collections.Generic;

namespace greaterthany
{
    class Program
    {
        static void Main(string[] args)
        {
            int greaterthan(List<int> arr, int y)
            {
                int sumgreater = 0;
                foreach (int item in arr)
                {
                    if(item > y)
                    {
                        sumgreater++;
                    }
                }
                return sumgreater;
            }
            List<int> TestArray = new List<int>()
            {
                1, 5, 100, 32, 55, 2, 1
            };
            Console.WriteLine(greaterthan(TestArray, 50)); // testarray should return 2 printed to console
        }
    }
}
