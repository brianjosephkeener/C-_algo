using System;

/*

ReverseString
Implement a function reverseString(str) that, given a string, will return the string of the same length but with characters reversed. 
Example: given ​"creature"​, return ​"erutaerc"​. Do not use the built-in reverse()​ function!

*/

namespace reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "test123";
            string reversetest = "";
            for (int i = 0; i < test.Length; i++)
            {
                reversetest += (test[test.Length-1-i]);
            }
            Console.WriteLine(reversetest);
        }
    }
}
