using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REIZ_TECH_Problem_01
{
    internal class Clock
    {
        static void Main(string[] args)
        {
            /*
            hour hand moves 0.5 degree in 1 minute
                            30  degree in 1 hour 
            minute hand moves 6 degree in 1 minute
            */

            while (true)
            {
                Console.Write("Please, provide clock time (eg - 5:30):- ");

                string time = Console.ReadLine();

                string[] times = time.Split(':');



                int hour = Int32.Parse(times[0]);
                int minute = Int32.Parse(times[1]);

                if (times.Length == 2 && (hour >= 1 || hour <= 12) && (minute >= 0 || minute <= 60))
                {
                    double hourHand = (30 * hour) + (0.5 * minute);
                    if (hourHand >= 360)
                    {
                        hourHand = 360 - hourHand;
                    }

                    double minuteHand = (6 * minute);
                    if (minuteHand == 360)
                    {
                        minuteHand = 0;
                    }

                    double difference = Math.Abs(hourHand - minuteHand);

                    if (difference > 180)
                    {
                        difference = 360 - difference;
                    }

                    Console.WriteLine(hourHand + " and " + minuteHand);

                    Console.WriteLine("Difference between hour and minute hand is: " + difference + "°");


                }
                else
                {
                    Console.WriteLine("Invalid Time");
                }

                Console.ReadKey();

            }
            
        }
    }
}
