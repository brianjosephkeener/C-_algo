using System;

/*

Second-to-Last

Return the second-to-last element of an array.

*/

namespace _2nd_to_last_in_array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] testArray = {"hello", "world", "name", "is", "brian"};
            Console.WriteLine(testArray[testArray.Length-2]);
        }
    }
}
