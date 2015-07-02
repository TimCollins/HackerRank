using System;
using Algorithms;
using Domain.Implementation;
using Utils;

namespace ChallengeRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            //new LibraryFine().SolveIt();

            string[] actualReturnDate = Console.ReadLine().Split(' ');
            string[] expectedReturnDate = Console.ReadLine().Split(' ');

            int actualDay = Convert.ToInt32(actualReturnDate[0]);
            int expectedDay = Convert.ToInt32(expectedReturnDate[0]);

            int actualMonth = Convert.ToInt32(actualReturnDate[1]);
            int expectedMonth = Convert.ToInt32(expectedReturnDate[1]);

            int actualYear = Convert.ToInt32(actualReturnDate[2]);
            int expectedYear = Convert.ToInt32(expectedReturnDate[2]);

            DateTime actual = new DateTime(actualYear, actualMonth, actualDay);
            DateTime expected = new DateTime(expectedYear, expectedMonth, expectedDay);

            if (actual.Equals(expected) || actual < expected)
            {
                Console.WriteLine(0);
                return;
            }

            int daysDiff = Math.Abs((expected - actual).Days);
            int yearsDiff = Math.Abs((expected.Year - actual.Year));

            if (yearsDiff > 0)
            {
                Console.WriteLine(10000);
                return;
            }

            int fine;
            if (daysDiff > 31)
            {
                fine = (daysDiff / 30) * 500;
            }
            else
            {
                fine = daysDiff * 15;
            }

            Console.WriteLine(fine);
            ConsoleUtils.WaitForEscape();
        }
    }
}
