using System;

/*

Get String Digits

Given "0s1a3y5w7h9a2t4?6!8?0", the function should return the number 01357924680.

*/

namespace Get_String_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "0s1a3y5w7h9a2t4?6!8?0";
            for (int i = 0; i < test.Length; i++)
            {
                if(!Char.IsDigit(test[i]))
                {
                    test = test.Remove(i, 1);
                }
            }
            Console.WriteLine(test);
        }
    }
}
