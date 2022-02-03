using System;

namespace sumof1000
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 2; i <= 1000; i=i+2)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);
        }
    }
}
