using System;

/*

Remove Blanks
Create a function that, given a string, returns the string, without blanks. 
Given ​" play that Funky Music "​, returns a string containing ​"playthatFunkyMusic"​.

*/

namespace remove_Blanks
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "123 456 789";
            for (int i = 0; i < test.Length; i++)
            {
                if(Char.IsWhiteSpace(test[i]))
                {
                    test = test.Remove(i, 1);
                }
            }
            Console.WriteLine(test);
        }
    }
}
