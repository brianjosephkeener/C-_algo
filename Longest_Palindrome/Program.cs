using System;

/*

Longest Palindrome

For this challenge, we will look not only at the entire string, but also substrings within it.
For a string, return the longest palindromic substring. Given ​"what up, dada?"​, return "dad"​. 
Given ​"not much"​, return ​"n"​. 
​Include spaces​ as well (i.e. be strict, as in the “Is Palindrome” challenge): given ​"My favorite racecar erupted!"​, return ​"e racecar e"​.

*/

namespace Longest_Palindrome
{
    class Program
    {
        static string LPal(string str)
        {
            string lp = "";
            char[] strarr = str.ToCharArray();
            for (int i = 0; i < strarr.Length; i++)
            {
                for (int i = 0; i < length; i++)
                {
                    
                }
            }
            return lp;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(LPal("what up, dada")); // "what up, dada?"​, return "dad"
            Console.WriteLine(LPal("not much")); // Given ​"not much"​, return ​"n"
            Console.WriteLine(LPal("My favorite racecar erupted")); // return "e racecar e"
        }
    }
}
