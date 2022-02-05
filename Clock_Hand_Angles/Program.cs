using System;

/*

Traditional clocks are increasingly uncommon, but most can still read rotating hands of hours, minutes,
and seconds.
Create function clockHandAngles(seconds)​ that, given the number of seconds since 12:00:00, will
print the angles (in degrees) of the hour, minute and second hands. As a quick review, there are 360
degrees in a full arc rotation. Treat “straight-up” 12:00:00 as 0 degrees for all hands.

*/

namespace Clock_Hand_Angles
{
    class Program
    {
        
        public static void clockHandAngles(double seconds)
        {
            double hourh = 0; double minuteh = 0; double secondh = 0;
            hourh = (seconds * (0.00833333333));
            while(hourh >= 360)
            {
                hourh = hourh - 360;
            }
            minuteh = (seconds * (0.1));
            while(minuteh >= 360)
            {
                minuteh = minuteh - 360;
            }
            secondh = (seconds * 6);
            while(secondh >= 360)
            {
                secondh = secondh - 360;
            }
            Console.WriteLine($"hour hand degrees: {hourh}, minute hand degrees: {minuteh}, second hand degrees: {secondh}");
        }


        static void Main(string[] args)
        {
            clockHandAngles(20000);
        }
    }
}
