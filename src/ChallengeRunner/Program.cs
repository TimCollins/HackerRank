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
            new LibraryFine().SolveIt();

            string[] actualReturnDate = Console.ReadLine().Split(' ');
            string[] expectedReturnDate = Console.ReadLine().Split(' ');

            int actualDay = Convert.ToInt32(actualReturnDate[0]);
            int expectedDay = Convert.ToInt32(expectedReturnDate[0]);

            int actualMonth = Convert.ToInt32(actualReturnDate[1]);
            int expectedMonth = Convert.ToInt32(expectedReturnDate[1]);

            int actualYear = Convert.ToInt32(actualReturnDate[2]);
            int expectedYear = Convert.ToInt32(expectedReturnDate[2]);
            int fine;
            if ((actualDay == expectedDay) &&
                (actualMonth == expectedMonth) &&
                (actualYear == expectedYear))
            {
                fine = 0;
            }
            else
            {
                fine = 57;    
            }

            
            
            Console.WriteLine(fine);
            //If the book is returned on or before the expected return date, no fine will be charged, in other words fine is 0.
            //If the book is returned in the same month as the expected return date, Fine = 15 Hackos × Number of late days
            //If the book is not returned in the same month but in the same year as the expected return date, Fine = 500 Hackos × Number of late months
            //If the book is not returned in the same year, the fine is fixed at 10000 Hackos.
            //TimeConversion.SolveIt();
            ConsoleUtils.WaitForEscape();
        }
    }
}
