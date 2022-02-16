using System;

/*

Braces Valid
Given a string, returns whether the sequence of various parentheses, braces and brackets within it are valid. 
For example, given the input string "w(a{t}s[o(n{c}o)m]e)h[e{r}e]!"​, return true​. 
Given ​"d(i{a}l[t]o)n{e"​, return false​. Given ​"a(1)s[O(n]0{t)0}k"​, return true​.

*/

namespace Braces_Valid
{
    class Program
    {
        static bool BraceVal(string str)
        {
            short parcount = 0;
            short bracount = 0;
            short squigcount = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if(Char.ToString(str[i]) == ")")
                {
                    parcount--;
                }
                if(Char.ToString(str[i]) == "]")
                {
                    bracount--;
                }
                if(Char.ToString(str[i]) == "}")
                {
                    squigcount--;
                }
                if(parcount < 0 || bracount < 0 || squigcount < 0)
                {
                    return false;
                }
                if(Char.ToString(str[i]) == "(")
                {
                    parcount++;
                }
                if(Char.ToString(str[i]) == "[")
                {
                    bracount++;
                }
                if(Char.ToString(str[i]) == "{")
                {
                    squigcount++;
                }
            }
            if(parcount == 0 && squigcount == 0 && bracount == 0)
            {
            return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(BraceVal("w(a{t}s[o(n{c}o)m]e)h[e{r}e]!"));
            Console.WriteLine(BraceVal("d(i{a}l[t]o)n{e"));
            Console.WriteLine(BraceVal("a(1)s[O(n]0{t)0}k"));
        }
    }
}
