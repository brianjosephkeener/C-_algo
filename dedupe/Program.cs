using System;

/*

Remove Duplicates

Remove duplicates from an array. Do not alter the original array; return a new one, keeping results ​‘stable’​ (retain original order). 
Given [1, 2, 1, 3, 4, 2], return a new array [1, 2, 3, 4].

*/



namespace dedupe
{
    class Program
    {
        static int[] deDupe(int[] parArr)
        {
            int[] result = new int[];
            for (int i = 0; i < parArr.Length; i++)
            {
                int numCheck = parArr[i];
                for (int j = 0; j < parArr.Length; j++)
                {
                    if(numCheck = parArr[j])
                    {

                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] {1, 2, 1, 1, 3, 4, 2};

        }
    }
}
