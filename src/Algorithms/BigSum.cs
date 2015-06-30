using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class BigSum
    {
        public static void SolveIt()
        {
            int noItems = Convert.ToInt32(Console.ReadLine());

            string consoleInput = Console.ReadLine();
            if (string.IsNullOrEmpty(consoleInput))
            {
                return;
            }

            string[] inputStrings = consoleInput.Split(' ');
            List<int> inputNumbers = new List<int>();

            for (int i = 0; i < noItems; i++)
            {
                inputNumbers.Add(Convert.ToInt32(inputStrings[i]));
            }

            long total = 0;

            for (int i = 0; i < inputNumbers.Count; i++)
            {
                total += inputNumbers[i];
            }

            Console.WriteLine(total);
        }
    }
}
