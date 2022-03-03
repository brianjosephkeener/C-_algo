using System;

/*

Write a recursive function that, given a number, returns the sum of integers from one up to that number. 
For example, rSigma(5) = 1+2+3+4+5 = 15; rSigma(2.5) = 1+2 = 3; rSigma(-1) = 0.

*/

namespace rSigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int sigma(int entry, int x = 0, int y = 0)
            {
                if(entry != x)
                {
                    return sigma(entry-1, x++, y+=entry);
                }
                Console.WriteLine(y);
                return y;
            }
                sigma(3);
                sigma(5);
        }
    }
}
