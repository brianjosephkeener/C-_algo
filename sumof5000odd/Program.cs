using System;

namespace sumof5000odd
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 5000; i=i+2)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);
        }
    }
}
