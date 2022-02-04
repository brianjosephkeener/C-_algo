using System;
using System.Collections.Generic;

/*

Statistics to Doubles

Implement a ‘die’ that randomly returns an
integer between 1 and 6 inclusive. Roll a pair of
these dice, tracking the statistics until doubles
are rolled. Display the number of rolls, min, max,
and average.

*/

namespace statistic_to_doubles
{
    class Program
    {
        static void Main(string[] args)
        {
            int die1 = 0;
            int die2 = 6;
            List<string> DoubleDie()
            {
                List<string> array = new List<string>();
                System.Random rand = new Random();
                int rolls = 0;
                int max = 0;
                int average = 0;
                int min = 12;
                do
                {
                    int die1 = rand.Next(1,6);
                    int die2 = rand.Next(1,6);
                    rolls++;
                    average = die1 + die2 + average;
                    if(min > die1 + die2)
                    {
                        min = die1 + die2;
                    }
                    if(max < die1 + die2)
                    {
                        max = die1 + die2;
                    }
                    if(die1 == die2)
                    {
                        average = average / rolls;
                        break;
                    }
                } while (die1 != die2);

                array.Add(rolls + " rolls");
                array.Add(max + " max");
                array.Add(min + " min");
                array.Add(average + " average");

                foreach (string item in array)
                {
                    Console.WriteLine(item);
                }
                return array;
            }
            DoubleDie();
        }
    }
}
