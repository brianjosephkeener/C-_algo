using System;

/*


Rotate String
Create a standalone function that accepts a string and an integer, and rotates the characters in the string to the right by that amount.
Example: given ​("Boris Godunov",5)​, return ​"dunovBoris Go"​.

*/

namespace Rotate_String
{
    class Program
    {
        static string rString(string input, int amount)
        {
            string result = "";
            for (int i = input.Length - amount; i < input.Length; i++)
            {
                result+=input[i];
            }
            for (int i = 0; i < input.Length - amount; i++)
            {
                result+=input[i];
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(rString("Boris Godunov", 5));
        }
    }
}
