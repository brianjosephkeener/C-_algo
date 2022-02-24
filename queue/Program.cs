using System;
using System.Collections;

/*

Front
return the value at front of our queue, without removing it.


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
        static void Main(string[] args)
        {
            Queue q = new Queue();
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
        }
    }
}
