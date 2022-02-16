using System;

/*

Book Index
Write a function that given a sorted array of page numbers, return a string representing a book index. 
Combine consecutive pages to create ranges. 
Given ​[1, 3, 4, 5, 7, 8, 10]​, return the string ​"1, 3-5, 7-8, 10"​.

*/

namespace Book_Index
{
    class Program
    {
        static string BIndex(int[] arr)
        {
            string str = "";
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if(arr[i] + 1 != arr[i+1])
                {
                    str+=arr[i] + ", ";
                }
                else if (arr[i] < arr[i+1])
                {
                    for (int j = i; j < arr.Length - 1; j++)
                    {
                        if (arr[j] + 1 != arr[j+1])
                        {
                            str+=arr[i] + "-" + arr[j] + ", ";
                            i = j;
                            break;
                        }
                    }
                }
            }
            return str + arr[arr.Length-1];
        }
        static void Main(string[] args)
        {
            int[] testarr = new int[]{1, 3, 4, 5, 7, 8, 10};
            Console.WriteLine(BIndex(testarr));
        }
    }
}
