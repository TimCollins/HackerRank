using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class DiagonalDifference
    {
        public static void SolveIt()
        {
            int noLines = Convert.ToInt32(Console.ReadLine());
            List<string> inputStrings = new List<string>();

            for (int i = 0; i < noLines; i++)
            {
                inputStrings.Add(Console.ReadLine());
            }

            int cnt = 0;
            int firstDiagonalSum = 0;
            for (int i = 0; i < noLines; i++)
            {
                string[] line = inputStrings[i].Split(' ');
                firstDiagonalSum += GetInt(line[cnt]);
                cnt++;
            }

            cnt--;
            int secondDiagonalSum = 0;

            for (int i = 0; i < noLines; i++)
            {
                string[] line = inputStrings[i].Split(' ');
                secondDiagonalSum += GetInt(line[cnt]);
                cnt--;
            }

            Console.WriteLine(Math.Abs(firstDiagonalSum - secondDiagonalSum));
        }

        private static int GetInt(string input)
        {
            return Convert.ToInt32(input);
        }
    }
}
