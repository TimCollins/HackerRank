using System;

namespace Algorithms
{
    public class PlusMinus
    {
        public static void SolveIt()
        {
            int noItems = Convert.ToInt32(Console.ReadLine());
            string[] items = Console.ReadLine().Split(' ');

            int posCnt = 0, negCnt = 0, zeroCnt = 0;

            for (int i = 0; i < items.Length; i++)
            {
                int itemValue = Convert.ToInt32(items[i]);

                if (itemValue > 0)
                {
                    posCnt++;
                }
                else if (itemValue < 0)
                {
                    negCnt++;
                }
                else
                {
                    zeroCnt++;
                }
            }

            Console.WriteLine((float)posCnt / noItems);
            Console.WriteLine((float)negCnt / noItems);
            Console.WriteLine((float)zeroCnt / noItems);
        }
    }
}
