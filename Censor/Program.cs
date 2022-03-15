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
        static string Censor(string inputStr, string[] nauWord)
        {
            string[] input = inputStr.Split(' ');
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < nauWord.Length; j++)
                {
                    int index = input[i].IndexOf(nauWord[j]);
                    if(index > -1 )
                    {
                        for (int k = index; k < input[i].Length; k++)
                        {
                            
                        }
                    }
                }
            }
            return "";
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
