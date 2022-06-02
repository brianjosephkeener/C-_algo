using System;
using System.Collections.Generic;

namespace NextPrime
{

    //  Given an integer, create a function that returns the next prime.
    class Program
    {
        static int NextPrime(int input)
        {
            input++;
            for (int i = 2; i < input; i++) {
                if(input%i == 0) {
                    input++;
                    i=2;
                    } 
                else {
                    continue;
                    }
            }
            return input;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("type in the number to find next prime");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(NextPrime(number));
        }
    }
}
