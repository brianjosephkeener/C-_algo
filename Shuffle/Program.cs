using System;
using System.Linq;
using System.Security.Cryptography;

namespace Shuffle
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Random random = new Random();
            arr = arr.OrderBy(x => random.Next()).ToArray();
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
