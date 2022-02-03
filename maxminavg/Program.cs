using System;
using System.Collections.Generic;

namespace maxminavg
{
    class Program
    {
        static void Main(string[] args)
        {
            List<float> minmaxavg(List<float> arr)
            {
                List <float> newarr = new List<float>();
                float min = float.MaxValue;
                float max = float.MinValue;
                float avg = 0;

                foreach (float item in arr)
                {
                    if(item < min)
                    {
                        min = item;
                    }
                    if(item > max)
                    {
                        max = item;
                    }
                    avg = avg + item;
                }
                avg = avg / arr.Count;
                newarr.Add(max);
                newarr.Add(min);
                newarr.Add(avg);
                return newarr;
            }
            List <float> Testarr = new List<float>()
            {
                1, 5, 10, -2
            }; 
            foreach (float item in minmaxavg(Testarr))
            {
                Console.WriteLine(item);
            }
        }
    }
}
