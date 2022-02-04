using System;

/*

Sum To One Digit

Implement a function sumToOne(num)​ that,
given a number, sums that number’s digits
repeatedly until the sum is only one digit. Return
that final one digit result. (12345 will print 6)

*/


namespace sum_to_one_digit
{
    class Program
    {
        static void Main(string[] args)
        {
            int Sum2One(int num)
            {
                int remainder = num % 9;
                int fvalue = (remainder == 0) ? 9 : remainder;
                Console.Write(fvalue); 
                return fvalue;
            }
            Sum2One(12345);
        }
    }
}
