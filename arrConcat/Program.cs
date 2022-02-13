using System;
using System.Collections.Generic;
using System.Linq;

/*

arrConcat

Replicate JavaScript’s ​concat()​. 
Return a ​new​ array containing the first array’s elements, followed by the second array’s elements. 
Do not alter the original arrays. Ex.: arrConcat( ['a','b'], [1,2] )​ should return ​['a','b',1,2]​.

*/

namespace arrConcat
{
    class Program
    {
        static void Main(string[] args)
        {
        List<int> first = new List<int>() { 1, 2, 3, 4, 5 };
        List<int> second = new List<int>() { 4, 7, 8, 9 };

        List<int> result = first.Concat(second).ToList();
        Console.WriteLine(String.Join(",", result));
        }
    }
}
