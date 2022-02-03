using System;
using System.Collections.Generic;
namespace iteratearray
{
    class Program
    {
        static void Main(string[] args)
        {
            void iteratearr(List<int> arr)
            {
                int sum = 0;
                foreach (int item in arr)
                {
                    sum = sum + item;
                }
                Console.WriteLine(sum);
            }
            List<int> Tester = new List<int>(
            ) {10, 5, 5};
            iteratearr(Tester);
        }
    }
}
