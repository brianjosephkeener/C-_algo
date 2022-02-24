using System;
using System.Collections;

/*

Enqueue
Create ​slQueue​ method ​enqueue(val)​ to add the given value to end of our queue. 
Remember, slQueue​ uses a singly linked list (not an array).

*/

namespace queue
{
    class Program
    {
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
        }
    }
}
