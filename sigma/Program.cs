using System;
using System.Collections.Generic;

/*

Sigma

Implement a function ​sigma(num)​ that, given a number, returns the sum of all positive integers from 1 up to number (inclusive). 
Ex.: ​sigma(3) = 6 (or 1+2+3); ​sigma(5)​ = 15 (or 1+2+3+4+5).

*/

namespace sigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int sigma(int entry)
            {
                int x = 0;
                int y = entry;
                while (entry != x)
                {
                    y+=x;
                    x++;
                }
                Console.WriteLine(y);
                return y;
            }
                sigma(3);
                sigma(5);
        }
    }
}
