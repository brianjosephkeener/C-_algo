using System;
using System.Collections;

namespace stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            // adding values to stack with push
            s.Push(1);
            s.Push(2);
            s.Push(3);
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
        }
    }
}
