using System;
using System.Collections.Generic;

/*

Remove Duplicates

Remove duplicates from an array. Do not alter the original array; return a new one, keeping results ​‘stable’​ (retain original order). 
Given [1, 2, 1, 3, 4, 2], return a new array [1, 2, 3, 4].

*/



namespace dedupe
{
    class Program
    {
        static List<int> deDupe(List<int> parArr)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < parArr.Count; i++)
            {
                if(result.Count < 1)
                {
                    result.Add(parArr[i]);
                    continue;
                }
                else
                {
                    for (int j = 0; j < parArr.Length; j++)
                 {
                        if(result[j] == result[i])
                        {
                            // need work on how to not alter original array
                        }
                    }
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            List<int> arr = new List<int> {1, 2, 1, 1, 3, 4, 2};
            foreach (int item in deDupe(arr))
            {
                Console.WriteLine(item);
            }
        }
    }
}
