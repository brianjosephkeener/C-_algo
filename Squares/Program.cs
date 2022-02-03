using System;
using System.Collections.Generic;
namespace Squares
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Square(List<int> ArrayS)
            {
                for (int i = 0; i < ArrayS.Count; i++)
                {
                    ArrayS[i] = ArrayS[i] * ArrayS[i];
                }
                return ArrayS;
            }
        List<int> testarray = new List<int>()
        {
            1, 2, 5, 10
        };
        foreach (int item in Square(testarray))
        {
            Console.WriteLine(item);
        }

        }
    }
}
