using System;

namespace Flatten
{

class Program
{
    static int[] To1DArray(int[,] input)
    {
        // Step 1: get total size of 2D array, and allocate 1D array.
        int size = input.Length;
        int[] result = new int[size];

        // Step 2: copy 2D array elements into a 1D array.
        int write = 0;
        for (int i = 0; i <= input.GetUpperBound(0); i++)
        {
            for (int z = 0; z <= input.GetUpperBound(1); z++)
            {
                result[write++] = input[i, z];
            }
        }
        // Step 3: return the new array.
        return result;
    }

    static void Main()
    {
        int[,] elements = { { 10, 20, 30 }, { 40, 50, 60 } };

        // Convert 2D array to 1D array.
        int[] result = To1DArray(elements);

        // Write flat array.
        foreach (int value in result)
        {
            Console.WriteLine("ELEMENT: {0}", value);
        }
    }
}
}