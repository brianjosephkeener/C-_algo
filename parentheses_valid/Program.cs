using System;

/*

Parens Valid
Create a function that, given an input string, returns a boolean whether parentheses in that string are valid.
Given input ​"y(3(p)p(3)r)s"​, return true.
Given ​"n(0(p)3"​, return ​false​.
Given ​"n)0(t(0)k"​, return ​false​.

*/

namespace parentheses_valid
{
    class Program
    {
        static bool ParVal(string str)
        {
            short count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if(Char.ToString(str[i]) == ")")
                {
                    count--;
                }
                if(count < 0)
                {
                    return false;
                }
                if(Char.ToString(str[i]) == "(")
                {
                    count++;
                }
            }
            if(count == 0)
            {
            return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ParVal("y(3(p)p(3)r)s"));
            Console.WriteLine(ParVal("n(0(p)3"));
            Console.WriteLine(ParVal("n)0(t(0)k"));
        }
    }
}
