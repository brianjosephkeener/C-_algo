using System;
using System.Collections;

namespace stack
{
    class Program
    {
        static object Top(Stack s)
        {
            // return top value of stack without removing it
            return s.ToArray()[0];
        }
        static void Main(string[] args)
        {
            Stack s = new Stack();
            // adding values to stack with push
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);
            // removing top value to stack with pop
            s.Pop();
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(Top(s));
        }
    }
}
