using Algorithms;
using Domain.Interfaces;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class LibraryFineTests
    {
        [Test]
        public void MatchingDatesGiveZeroFine()
        {
            new LibraryFine(new TestReader()).SolveIt();

            Assert.AreEqual(1, 1);
        }
    }

    internal class TestReader : IConsoleReader
    {
        public string ReadLine()
        {
            return "1 2 3";
        }

        public int Read()
        {
            return 1;
        }
    }
}
