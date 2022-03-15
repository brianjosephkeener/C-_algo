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
            char[] input = inputStr.ToCharArray();
            int count = 0;
            string temp = "";
            for (int i = 0; i < input.Length; i++)
            {
                if(Char.IsWhiteSpace(input[i]) == false)
                {
                    Console.WriteLine(temp);
                    temp+=input[i];
                    count++;
                }
                else if(i == input.Length - 1)
                {
                    for (int j = 0; j < nauWord.Length; j++)
                    {
                        if(temp == nauWord[j])
                        {
                            for (int k = i-count; k < count; k++)
                            {
                                input[k] = 'x';
                            }
                        }
                    }
                    temp = "";
                    count = 0;
                }
                else {
                    for (int j = 0; j < nauWord.Length; j++)
                    {
                        if(temp == nauWord[j])
                        {
                            for (int k = i-count; k < count; k++)
                            {
                                input[k] = 'x';
                            }
                        }
                    }
                    temp = "";
                    count = 0;
                }
            }
            string result = new string(input);
            return result;
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
