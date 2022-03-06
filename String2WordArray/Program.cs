using System;
using System.Collections.Generic;

/*

String2WordArray

Given a string of words (with spaces or tabs), returns an array of words. 
Given "Life is not a drill!"​ return ​["Life", "is" "not", "a", "drill!"]​.


*/

namespace String2WordArray
{
    class Program
    {
        static List<string> Str2WArr(string input)
        {
            char[] inputArr = input.ToCharArray();
            List<string> result = new List<string>();
            string temp = "";
            for (int i = 0; i < inputArr.Length; i++)
            {
                if(Char.IsWhiteSpace(inputArr[i]) != true)
                {
                    temp+=inputArr[i].ToString();
                }
                else {
                    result.Add(temp);
                    temp = "";
                }
                if(i == inputArr.Length - 1)
                {
                    result.Add(temp);
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            foreach (string item in Str2WArr("Life is not a drill!"))
            {
                Console.WriteLine(item);
            }
        }
    }
}
