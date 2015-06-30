using System;

namespace Algorithms
{
    public class Staircase
    {
        public static void SolveIt()
        {
            int noSteps = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < noSteps + 1; i++)
            {
                for (int j = noSteps - i; j > 0; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < i; k++)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }
        }
    }
}
