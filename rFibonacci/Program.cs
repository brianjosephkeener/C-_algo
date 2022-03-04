using System;

/*

Recursive Fibonacci

*/

namespace rFibonacci
{
    class Program
    {
        static int rFib(int n, int iter = 2, int firstnumber = 0, int secondnumber = 1, int result = 0)  
        {  
            if (n == 0) return 0; //To return the first Fibonacci number   
            if (n == 1) return 1; //To return the second Fibonacci number   
            if(iter <= n)
            {
                iter++;
                result = firstnumber + secondnumber;
                firstnumber = secondnumber;
                secondnumber = result;
                return rFib(n, iter, firstnumber, secondnumber, result);
            }
            return result;  
        }  
   
        static void Main(string[] args)  
        {  
            Console.Write("Enter the length of the Fibonacci Series: ");  
            int length = Convert.ToInt32(Console.ReadLine());  
   
            for (int i = 0; i < length; i++)  
            {  
                Console.Write("{0} ", rFib(i));  
            }  
        }  
    }
}
