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
            string result = "";
            for (int i = 0; i < input.Length; i++)
            {
                char[] inputChArr = input[i].ToCharArray();
                for (int j = 0; j < nauWord.Length; j++)
                {
                    char[] nauWordChArr = nauWord[j].ToCharArray();
                    int count = 0;
                    bool trigger = false;
                    int temp = 0;
                    for (int k = 0; k < inputChArr.Length; k++)
                    {
                        if(inputChArr[k] == nauWordChArr[count])
                        {
                            count++;
                            if(trigger == false)
                            {
                                trigger = true;
                                temp = k;
                            }
                            if(count == nauWordChArr.Length)
                            {
                                for (int l = temp; l < count + temp; l++)
                                {
                                    inputChArr[l] = 'x';
                                }
                                count = 0;
                                trigger = false;
                            }
                        }
                        else
                        {
                            count = 0;
                            trigger = false;
                        }
                    }
                }
            string convertedToString = new string(inputChArr);
            result += convertedToString + " ";
            }
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
