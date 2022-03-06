using System;
using System.Collections.Generic;

/*

Longest Word

Create a function that, given a string of words, returns the longest word. 
Example: given ​"Snap crackle pop makes the world go round!"​, return ​"crackle"​.

*/

namespace Longest_Word
{
    class Program
    {
        private static string lWord(string input)
        {
            string lword = "";
            string temp = "";
            for (int i = 0; i < input.Length; i++)
            {
                if(Char.IsWhiteSpace(input[i]) == false)
                {
                    temp+=input[i];
                }
                else if(i == input.Length - 1)
                {
                    if(temp.Length > lword.Length)
                    {
                        lword = temp;
                    }
                    temp = "";
                }
                else {
                    if(temp.Length > lword.Length)
                    {
                        lword = temp;
                    }
                    temp = "";
                }
            }
            return lword;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(lWord("Snap crackle pop makes the world go round!"));
        }
    }
}
