using System;
using System.Collections;

/*

Size
Create ​slQueue​ method ​size()​ that returns the number of values in our queue.

*/

namespace queue
{
    class Program
    {
        static object Front(Queue q)
        {
            Console.WriteLine(q.ToArray()[0]);
            return q.ToArray()[0];
        }
        static bool IsEmpty(Queue q)
        {
            if(q.Count < 1)
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Queue q = new Queue();
            Queue emptyQueue = new Queue();
            // Load string char into queue data structure 
            q.Enqueue('A');
            q.Enqueue('B');
            q.Enqueue('C');
            q.Enqueue('D');
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            // Delete first obj in queue 
            q.Dequeue();
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            // return first obj in queue
            Front(q);
            Console.WriteLine(q.Contains('A'));
            Console.WriteLine(q.Contains('D'));
            Console.WriteLine(IsEmpty(q));
            Console.WriteLine(IsEmpty(emptyQueue));
        }
    }
}
