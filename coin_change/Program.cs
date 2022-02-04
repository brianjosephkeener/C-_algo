using System;
using System.Collections.Generic;

/*

Generate Coin Change

Implement generateCoinChange(cents)​ that accepts a parameter for the number of cents, and
computes how to represent that amount with the smallest number of coins. Console.log the result.

*/

namespace coin_change
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> generateCoinChange(int cents)
            {
                List<string> coinage = new List<string>();
                int qtotal = 0;
                int dtotal = 0;
                int ntotal = 0;
                int ptotal = 0;
                while(cents != 0)
                {
                    if(cents >= 25)
                    {
                        cents-=25;
                        qtotal++;
                        continue;
                    }
                    if(cents >= 10)
                    {
                        cents-=10;
                        dtotal++;
                        continue;
                    }
                    if(cents >= 5)
                    {
                        cents-=5;
                        ntotal++;
                        continue;
                    }
                    if(cents >= 1)
                    {
                        cents-=1;
                        ptotal++;
                    }
                }
                coinage.Add(qtotal + " quarters");
                coinage.Add(dtotal + " dimes");
                coinage.Add(ntotal + " nickles");
                coinage.Add(ptotal + " pennies");
                foreach (string item in coinage)
                {
                    Console.WriteLine(item);
                }
                return coinage;
            }
            generateCoinChange(100);
            generateCoinChange(74);
        }
    }
}
