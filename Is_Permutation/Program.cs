using System;

/*


Create a function that returns whether the second string is a permutation of the first. 
For example, given ​("mister","stimer")​, return ​true​. Given ​("mister", "sister")​, return ​false​.

Bonus:​ handle uppercase/lowercase.

*/

namespace Is_Permutation
{
    class Program
    {
        static bool Is_Permutation(string str1, string str2)
        {
            str1 = str1.ToLower();
            str2 = str2.ToLower();
            char[] strarr1 = str1.ToCharArray();
            char[] strarr2 = str2.ToCharArray();
            if(strarr1.Length != strarr2.Length)
            {
                return false;
            }
            for (int i = 0; i < strarr1.Length; i++)
            {
                for (int j = 0; j < strarr2.Length; j++)
                {
                    if(Array.IndexOf(strarr2, strarr1[i]) == -1) 
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Is_Permutation("mistEr","StImer")); // returns true
            Console.WriteLine(Is_Permutation("mister","sister")); // returns false 
        }
    }
}
