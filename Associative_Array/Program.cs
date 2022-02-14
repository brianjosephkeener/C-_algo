using System;
using System.Collections.Generic;

/*

Arrs2Map
Given two arrays, create an associative array (map) containing keys of the first, and values of the second. 
For ​arr1 = ["abc", 3, "yo"]​ and ​arr2 = [42, "wassup", true]​, return ​{"abc": 42, 3: "wassup", "yo": true}​.

*/


namespace Associative_Array
{
    class Program
    {
        static Dictionary<object, object> Arr2Map(List<object> key, List<object> val)
        {
            Dictionary<object, object> dic = new Dictionary<object, object>();
            for (int i = 0; i < key.Count; i++)
            {
                dic.Add(key[i], val[i]);
            }
            return dic;
        }
        static void Main(string[] args)
        {
            List<object> arr1 = new List<object>
            {
                "abc",
                3,
                "yo"
            };
            List<object> arr2 = new List<object>
            {
                42,
                "wassup",
                true
            };
            foreach (var item in Arr2Map(arr1, arr2))
            {
                Console.WriteLine(item);
            }
        }
    }
}
