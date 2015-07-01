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

        public void SolveIt()
        {
            string[] actualReturnDate = _reader.ReadLine().Split(' ');
            string[] expectedReturnDate = _reader.ReadLine().Split(' ');

            int i = 17;
        }
    }
}
