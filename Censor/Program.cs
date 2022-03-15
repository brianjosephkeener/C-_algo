using System;

/*

Censor
Create a function that, given a string and array of ​‘naughty words’,​ returns a new string with all naughty words changed to “x” characters. 
Example: given ​("Snap crackle pop nincompoop!" , ["crack", "poop"])​, return ​"Snap xxxxxle pop nincomxxxx!".​

*/

namespace Censor
{
    class Program
    {
        static string Censor(string input, string[] nauWord)
        {
            string temp = "";
            for (int i = 0; i < inputStr.Length; i++)
            {
                if(Char.IsWhiteSpace(input[i]) == false)
                {
                    temp+=input[i];
                }
                else if(i == input.Length - 1)
                {

                    temp = "";
                }
                else {
                    
                    temp = "";
                }
            }
        }
        static void Main(string[] args)
        {
            string[] testinput = new string[]
            {
                "crack",
                "poop"
            };
            Console.WriteLine(Censor("Snap crackle pop nincompoop!" , testinput));
        }
    }
}
