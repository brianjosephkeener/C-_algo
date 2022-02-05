using System;
using System.Collections.Generic;

/*

Last Digit of A to the B
Modern computers can handle very large numbers, but this ability has limits. If a number is repeatedly
multiplied by itself, it eventually exceeds the computer’s ability to accurately represent it. (Side note: the
number of times it is multiplied by itself is called the exponent.) For an optional end-of-chapter
challenge, determine the smallest (least significant) digit of a number that is potentially very, very large.
You may find that you must do this without computing the actual (unimaginably large) number.
Implement a function that accepts two non-negative integers as arguments. Function lastDigitAtoB(a,
b)​ should return the last digit of the first number (a) raised to an exponent of the second number (b).
Examples: given (3, 4)​, you should return 1​ (the last digit of 81: 3 * 3 * 3 * 3). Given (12, 5)​, return
2​ (the least significant digit of 248832, which is 12 * 12 * 12 * 12 * 12).

*/

namespace Last_Digit_of_A_to_the_B
{
    class Program
    {
    static int Modulo(int a, char[] b)
    {
        int mod = 0;
        for (int i = 0; i < b.Length; i++)
            mod = (mod * 10 + b[i] - '0') % a;
        return mod;
    }
    static int LastDigit(char[] a, char[] b)
    {
        int len_a = a.Length, len_b = b.Length;
        if (len_a == 1 && len_b == 1 &&
                   b[0] == '0' && a[0] == '0')
            return 1;
        if (len_b == 1 && b[0] == '0')
            return 1;
        if (len_a == 1 && a[0] == '0')
            return 0;
        int exp = (Modulo(4, b) == 0) ? 4 : Modulo(4, b);
        int res = (int)(Math.Pow(a[len_a - 1] - '0', exp));
        return res % 10;
    }
        static void Main(string[] args)
        {
        char[] a = "117".ToCharArray(),
        b = { '3' };
        Console.Write(LastDigit(a, b));
        }
    }
}
