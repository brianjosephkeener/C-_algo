using System;

/*

Acronyms
Create a function that, given a string, returns the string’s acronym (first letters only, capitalized). 
Given "there's no free lunch - gotta pay yer way"​, return ​"TNFLGPYW"​.
Given ​"Live from New York, it's Saturday Night!"​, return ​"LFNYISN"​.

*/

namespace Acronyms
{
    class Program
    {
        static string Acro(string str)
        {
            string acrostr = Char.ToString(str[0]).ToUpper();
            for (int i = 1; i < str.Length; i++)
            {
                if(Char.IsWhiteSpace(str[i]) && Char.IsLetter(str[i+1]))
                {
                    acrostr += Char.ToString(str[i+1]).ToUpper();
                }
            }
            Console.WriteLine(acrostr);
            return acrostr;
        }
        static void Main(string[] args)
        {
            string test1 = "there's no free lunch - gotta pay yer way";
            string test2 = "Live from New York, it's Saturday Night!";
            Acro(test1);
            Acro(test2);
        }
    }
}
