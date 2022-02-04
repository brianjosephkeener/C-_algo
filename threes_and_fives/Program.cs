using System;

/*

Threes and Fives

Create function ​ThreesFives()​ that adds each value from 100 and 4000000 (inclusive) 
if that value is evenly divisible by 3 or 5 ​but not both​. 

Display the final sum in the console.

Second:​ Change your function to make a ​BetterThreesFives(start,end)​where ​start​ and ​end values are customizable. 
You can think of the above ​ThreesFives()​ function as BetterThreesFives(100,4000000)​.

*/

namespace threes_and_fives
{
    class Program
    {
        static void Main(string[] args)
        {
            int ThreeFives()
            {
                int result = 0;
                for (int i = 100; i < 4000000; i++)
                {
                    if(i % 3 == 0 && i % 5 != 0 || i % 5 == 0 && i % 3 != 0)
                    {
                        result+=i;
                    }
                }
                Console.WriteLine(result);
                return result;
            }
            ThreeFives();
            int BetterThreesFives(int start, int end)
            {
                int result = 0;
                for (int i = start; i < end; i++)
                {
                    if(i % 3 == 0 && i % 5 != 0 || i % 5 == 0 && i % 3 != 0)
                    {
                        result+=i;
                    }
                }
                Console.WriteLine(result);
                return result;
            }
            BetterThreesFives(100, 4000000);
        }
    }
}
