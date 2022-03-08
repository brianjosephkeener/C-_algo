using System;
using System.Collections.Generic;

/*

Reverse Word Order

Create a function that, given a string of words (with spaces), returns new string with words in reverse sequence. 
Given ​"This is a test"​, return ​"test a is This"​.

*/

namespace Reverse_Word_Order
{
    class Program
    {
        public static string rWord(string input)
        {
            string rword = "";
            string temp = " ";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                if(Char.IsWhiteSpace(input[i]) == false)
                {
                    temp+=input[i];
                }
                else {
                        for (int j = temp.Length - 1; j >= 0; j--)
                        {
                            rword+=temp[j];
                        }
                    temp = " ";
                    }
                if(i == 0)
                {
                    for (int j = temp.Length - 1; j >= 0; j--)
                    {
                        rword+=temp[j];
                    }
                }
            }
            return rword;
            }
        static void Main(string[] args)
        {
            Console.WriteLine(rWord("This is a test"));
        }
    }
}

