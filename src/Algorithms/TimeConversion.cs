using System;

namespace Algorithms
{
    public class TimeConversion
    {
        public static void SolveIt()
        {
            string[] timeParts = Console.ReadLine().Split(':');

            if (timeParts[2].EndsWith("PM"))
            {
                int convertedHour = timeParts[0] == "12" ? 12 : Convert.ToInt32(timeParts[0]) + 12;

                if (convertedHour == 24)
                {
                    convertedHour = 0;
                }

                timeParts[0] = convertedHour.ToString("D2");
                timeParts[2] = timeParts[2].Substring(0, 2);
            }
            else if (timeParts[2].EndsWith("AM"))
            {
                if (timeParts[0] == "12")
                {
                    timeParts[0] = "00";
                }

                timeParts[2] = timeParts[2].Substring(0, 2);
            }

            Console.WriteLine("{0}:{1}:{2}", timeParts[0], timeParts[1], timeParts[2]);
        }
    }
}
