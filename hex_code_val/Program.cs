using System;
using System.Collections.Generic;
using System.Linq;

/*

A hex code must begin with a pound key # and is exactly 6 characters in length. 
Each character must be a digit from 0-9 or an alphabetic character from A-F. 
All alphabetic characters may be uppercase or lowercase.

*/

namespace hex_code_val
{
    class Program
    {
        static bool IsValidHexCode(string input)
        {
            if(input.Length == 7 && input[0] == '#')
            {
                for (int i = 1; i < input.Length; i++)
                {
                    char character = input[i];
                     if ((character < '0' || character > '9') &&
                        (character < 'A' || character > 'F'))
                            {
                                return false;
                            }
                }
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter a hexcode to validate it");
            string hexcode = Console.ReadLine();
            Console.WriteLine(IsValidHexCode(hexcode));
        }
    }
}
