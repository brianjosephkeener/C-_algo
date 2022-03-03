using System;

/*

Write a recursive function that, given a number, returns the sum of integers from one up to that number. 
For example, rSigma(5) = 1+2+3+4+5 = 15; sigma(3) = 6 (or 1+2+3);

*/

namespace rSigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int rSigma(int entry, int x = 0, int y = 0)
            {
                if(entry != x)
                {
                    y+=entry;
                    return rSigma(entry-1, x++, y);
                }
                Console.WriteLine(y);
                return y;
            }
                rSigma(5);
                rSigma(3);
        }
    }
}
