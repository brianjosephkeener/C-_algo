using System;

/*

Factorial
Write a function ​factorial(num)​ that, given a number, returns the product (multiplication) of all positive integers from 1 up to number (inclusive). 
For example, ​factorial(3)​ = 6 (or 1 * 2 * 3); factorial(5)​ = 120 (or 1 * 2 * 3 * 4 * 5).

*/

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int factorial(int entry)
            {
                int x = 1;
                int y = entry;
                while (entry != x)
                {
                    y*=x;
                    x++;
                }
                Console.WriteLine(y);
                return y;
            }
                factorial(3);
                factorial(5);
        }
    }
}
