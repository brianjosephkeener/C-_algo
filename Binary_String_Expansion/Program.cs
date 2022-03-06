using System;
using System.Collections.Generic;

/*

Binary String Expansion
You will be given a string containing characters ‘0’, ‘1’, and ‘?’. For every ‘?’, either ‘0’ or ‘1’ characters can be substituted. 
Write a recursive function that returns an array of all valid strings that have ‘?’ characters expanded into ‘0’ or ‘1’. 
Ex.: ​binStrExpand("1?0?")​ should return ["1000","1001","1100","1101"]​.

*/

namespace Binary_String_Expansion
{
    class Program
    {
        static List<List<string>> binStrExpand(string input)
        {
            inputArr = input.ToCharArray();
            List <List<string>> nest = new List<List<string>>();
            for (int i = 0; i < inputArr.Length; i++)
            {
                List <string> nestedArr = new List<string>();
                if(inputArr[i] != "?")
                {
                    nestedArr.Add(inputArr[i]);
                }
                else {
                    
                }
            }
        }
        static void Main(string[] args)
        {

        }
    }
}
