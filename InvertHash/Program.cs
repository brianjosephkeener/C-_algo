using System;
using System.Collections.Generic;

/*

Create invertHash(assocArr) that converts a hash’s keys to values and values to corresponding keys. 
Example: given ​{"name": "Zaphod"; "numHeads": 2}​, return ​{"Zaphod": "name"; 2: "numHeads"}​.

*/

namespace InvertHash
{
    class Program
    {
        static Dictionary<object, object> invertHash(Dictionary<object, object> hasharr)
        {
            Dictionary<object, object> dicinvert = new Dictionary<object, object>();
            foreach (var item in hasharr)
            {
                dicinvert.Add(item.Value, item.Key);
            }
            return dicinvert;
        }
        static void Main(string[] args)
        {
            Dictionary<object, object> dic = new Dictionary<object, object>{
                {"Brian Keener", "Developer"},
                {"hash key", 123},
                {456, "value"}
            };
            foreach (var item in invertHash(dic))
            {
                Console.WriteLine(item);
            }
        }
    }
}
