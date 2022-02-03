using System;
using System.Collections.Generic;

namespace IndexOfCapitals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            List<string> TextArr = new List<string>()
            {
                "AbCdEfg"
            };
            List<int> NewArr = new List<int>();
            foreach (string item in TextArr)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    if(char.IsUpper(item[i]) == true)
                    {
                        NewArr.Add(i);
                    }
                }
            }
            foreach (var item in NewArr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
