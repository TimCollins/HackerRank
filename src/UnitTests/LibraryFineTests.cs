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
            string[] input =
            {
                "9 6 2015",
                "9 6 2015"
            };

            int result = new LibraryFine(MoqUtil.SetupRandMock(input)).SolveIt();

            Assert.AreEqual(0, result);
        }

        [Test]
        public void ActualLessThanExpectedGivesZeroFine()
        {
            string[] input =
            {
                "5 6 2015",
                "9 6 2015"
            };

            int result = new LibraryFine(MoqUtil.SetupRandMock(input)).SolveIt();

            Assert.AreEqual(0, result);
        }

        [Test]
        public void ThreeDaysDifferenceGives45Fine()
        {
            string[] input =
            {
                "9 6 2015",
                "6 6 2015"
            };

            int result = new LibraryFine(MoqUtil.SetupRandMock(input)).SolveIt();

            Assert.AreEqual(45, result);
        }

        [Test]
        public void TwoMonthsDifferenceGives1000Fine()
        {
            string[] input =
            {
                "9 6 2015",
                "9 4 2015"
            };

            int result = new LibraryFine(MoqUtil.SetupRandMock(input)).SolveIt();

            Assert.AreEqual(1000, result);
        }

        [Test]
        public void EightMonthsDifferenceGives4000Fine()
        {
            string[] input =
            {
                "12 9 2015",
                "9 1 2015"
            };

            int result = new LibraryFine(MoqUtil.SetupRandMock(input)).SolveIt();

            Assert.AreEqual(4000, result);
        }

        [Test]
        public void YearDifferenceGivesBigFine()
        {
            string[] input =
            {
                "12 9 2016",
                "9 1 2015"
            };

            int result = new LibraryFine(MoqUtil.SetupRandMock(input)).SolveIt();

            Assert.AreEqual(10000, result);
        }

        [Test]
        public void FailingTest1()
        {
            string[] input =
            {
                "5 5 2014",
                "23 2 2014"
            };

            int result = new LibraryFine(MoqUtil.SetupRandMock(input)).SolveIt();

            Assert.AreEqual(1500, result);
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
