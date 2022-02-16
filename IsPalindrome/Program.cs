using System;

/*

Is Palindrome

Strings like ​"Able was I, ere I saw Elba"​ or ​"Madam, I'm Adam"​ could be considered ​palindromes​, 
because (if we ignore spaces, punctuation and capitalization) 
the letters are the same from front and back.

Create a function that returns a boolean whether the string is a ​strict​ palindrome. For ​"a x a"​ or "racecar"​, return ​true​. 
Do ​not​ ignore spaces, punctuation and capitalization: if given ​"Dud"​ or "oho!"​, return ​false​.

*/

namespace IsPalindrome
{
    class Program
    {
        static bool isPal(string str)
        {
            string strnorm = str;
            str = "";
            for (int i = 0; i < strnorm.Length; i++)
            {
                str += strnorm[strnorm.Length - 1 - i];
            }
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if(str[i] != strnorm[i])
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(isPal("a x a")); // true
            Console.WriteLine(isPal("racecar")); // true
            Console.WriteLine(isPal("Dud")); // false
            Console.WriteLine(isPal("oho!")); // false
        }
    }
}
