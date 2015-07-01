using System;
using Domain.Implementation;
using Domain.Interfaces;

namespace Algorithms
{
    public class LibraryFine
    {
        private readonly IConsoleReader _reader;

        public LibraryFine(IConsoleReader reader)
        {
            _reader = reader;
        }

        public LibraryFine()
        {
            _reader = new ConsoleReader();
        }

        public int SolveIt()
        {
            string[] actualReturnDate = _reader.ReadLine().Split(' ');
            string[] expectedReturnDate = _reader.ReadLine().Split(' ');

            int actualDay = Convert.ToInt32(actualReturnDate[0]);
            int expectedDay = Convert.ToInt32(expectedReturnDate[0]);

            int actualMonth = Convert.ToInt32(actualReturnDate[1]);
            int expectedMonth = Convert.ToInt32(expectedReturnDate[1]);

            int actualYear = Convert.ToInt32(actualReturnDate[2]);
            int expectedYear = Convert.ToInt32(expectedReturnDate[2]);
            int fine;

            DateTime actual = new DateTime(actualYear, actualMonth, actualDay);
            DateTime expected = new DateTime(expectedYear, expectedMonth, expectedDay);

            if (actual.Equals(expected) || actual < expected)
            {
                fine = 0;
            }
            else
            {
                int daysDiff = Math.Abs((expected - actual).Days);
                fine = daysDiff * 15;
            }


            int i = 17;

            return fine;
        }
    }
}
