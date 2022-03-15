using System;

namespace day1
{
    class Program
    {
        static int calculateBHeight(int height, int rebound)
        {
            for (int i = 0; i < rebound; i++)
            {
                height *=2;
            }
            return height;
        }
        static void Main(string[] args)
        {
            int H = int.Parse(Console.ReadLine());
            Console.WriteLine(calculateBHeight(H, 6));
        }
    }
}
