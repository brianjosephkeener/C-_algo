using System;

/*

Balance Point

Write a function that returns whether the given array has a balance point between indices, where one side’s sum is equal to the other’s. 
Example: ​[1,2,3,4,10]​ → ​true​ (​between indices 3 & 4)​ , but [1,2,4,2,1]​ → ​false​.

*/ 

namespace Balance_Point
{
    class Program
    {
        static bool bPoint(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int sumOfPrev = 0;
                int sumOfFoll = 0;
                int currI = i;
                if(currI == 0)
                    continue;
                for (int j = 0; j < currI; j++)
                {
                    sumOfPrev  += arr[j];
                }
			    for (int k = (currI + 1); k < arr.Length; k++)
                {
                    sumOfFoll += arr[k];
                }
			    if (sumOfPrev == sumOfFoll)
				return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            int[] arr1 = new int[] {2, 7, 4, 5, -3, 8, 9, -1}; // balance point: 3 and true
            int[] arr2 = new int[] {1,2,4,2,100}; // no balance point and false
            Console.WriteLine(bPoint(arr1));
            Console.WriteLine(bPoint(arr2));
        }
    }
}
