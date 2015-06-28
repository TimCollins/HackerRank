using System;

namespace Algorithms
{
    public class SolveMeSecond
    {
        public static void SolveIt()
        {
            int counter = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < counter; i++)
            {
                string consoleInput = Console.ReadLine();
                if (string.IsNullOrEmpty(consoleInput))
                {
                    continue;
                }
                string[] input = consoleInput.Split(' ');

                int first = Convert.ToInt32(input[0]);
                int second = Convert.ToInt32(input[1]);

                Console.WriteLine(first + second);
            }
        }
    }
}
