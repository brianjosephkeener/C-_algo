using System;
using System.Collections.Generic;

namespace hex_code_val
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please enter a hexcode to validate it");
            string hexcode = Console.ReadLine();
            Console.WriteLine(hexcode);
        }
    }
}
