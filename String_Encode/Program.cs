using System;

/*

String Encode

You are given a string that may contain sequences of consecutive characters. 
Create a function to shorten a string by including the character, then the number of times it appears. 
For ​"aaaabbcddd"​, return ​"a4b2c1d3"​. If result is not shorter (such as ​"bb"​=>​"b2"​), return the original string.

*/

namespace String_Encode
{
    class Program
    {
        static string Encode(string input)
        {
            char[] inputarr = input.ToCharArray();
            string result = "";
            int count = 1;
            for (int i = 0; i < inputarr.Length; i++)
            {
                    if(i+1 < inputarr.Length)
                    {
                        if(inputarr[i] == inputarr[i+1])
                        {
                            count++;
                        }
                        else 
                        {
                        result += inputarr[i].ToString() + count;
                        count = 1;
                        }
                    }
                    else 
                    {
                        result += inputarr[i].ToString() + count;
                    }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Encode("aaaabbcddd")); // returns a4b2c1d3
        }
    }
}
