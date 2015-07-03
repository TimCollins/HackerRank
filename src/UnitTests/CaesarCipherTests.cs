using Algorithms;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class CaesarCipherTests
    {
        [Test]
        public void BasicAlphabeticalTest()
        {
            string[] input =
            {
                "3",
                "abc",
                "2"
            };

            string output = new CaesarCipher(MoqUtil.SetupRandMock(input)).SolveIt();

            Assert.AreEqual("cde", output);
        }

        [Test]
        public void PunctuationShouldBeIgnored()
        {
            // 32 - 47 inclusive
            // 58 - 64 inclusive
            // 91 - 96 inclusive
            // 123 - 126 inclusive
            string[] input =
            {
                "30",
                "!\"#$%&'()*+-./:;<=>?`{|}~[\\]^_@",
                "2"
            };

            string output = new CaesarCipher(MoqUtil.SetupRandMock(input)).SolveIt();

            Assert.AreEqual("!\"#$%&'()*+-./:;<=>?`{|}~[\\]^_@", output);
        }

        [Test]
        public void MixedPunctuationAndLettersShouldBeHandled()
        {
            string[] input =
            {
                "7",
                "!^_!qrt",
                "2"
            };

            string output = new CaesarCipher(MoqUtil.SetupRandMock(input)).SolveIt();

            Assert.AreEqual("!^_!stv", output);
        }

        [Test]
        public void NumbersShouldBeIgnored()
        {
            string[] input =
            {
                "6",
                "123456",
                "2"
            };

            string output = new CaesarCipher(MoqUtil.SetupRandMock(input)).SolveIt();

            Assert.AreEqual("123456", output);
        }

        [Test]
        public void MixedPunctuationWithNumbersAndLettersShouldBeHandled()
        {
            string[] input =
            {
                "12",
                "123456abc!£$",
                "2"
            };

            string output = new CaesarCipher(MoqUtil.SetupRandMock(input)).SolveIt();

            Assert.AreEqual("123456cde!£$", output);
        }

        [Test]
        public void PoundAndEuroSignShouldBeHandled()
        {
            string[] input =
            {
                "4",
                "£€£€",
                "2"
            };

            string output = new CaesarCipher(MoqUtil.SetupRandMock(input)).SolveIt();

            Assert.AreEqual("£€£€", output);
        }

        [Test]
        public void RotatingLetterShouldWrapAround()
        {
            string[] input =
            {
                "3",
                "xyz",
                "2"
            };

            string output = new CaesarCipher(MoqUtil.SetupRandMock(input)).SolveIt();

            Assert.AreEqual("zab", output);
        }

        [Test]
        public void MixOfRotatingLettersNormalLettersNumbersAndPunctuationShouldBeHandled()
        {
            string[] input =
            {
                "6",
                "zf11@~",
                "2"
            };

            string output = new CaesarCipher(MoqUtil.SetupRandMock(input)).SolveIt();

            Assert.AreEqual("bh11@~", output);
        }

        [Test]
        public void UpperCaseLettersShouldBeHandled()
        {
            string[] input =
            {
                "3",
                "ABC",
                "2"
            };

            string output = new CaesarCipher(MoqUtil.SetupRandMock(input)).SolveIt();

            Assert.AreEqual("CDE", output);
        }

        [Test]
        public void UppercaseRotatingLettersShouldBeHandled()
        {
            string[] input =
            {
                "3",
                "XYZ",
                "2"
            };

            string output = new CaesarCipher(MoqUtil.SetupRandMock(input)).SolveIt();

            Assert.AreEqual("ZAB", output);
        }

        [Test]
        public void BasicCipher()
        {
            string[] input =
            {
                "11",
                "middle-Outz",
                "2"
            };

            // Do something
            string output = new CaesarCipher(MoqUtil.SetupRandMock(input)).SolveIt();

            Assert.AreEqual("okffng-Qwvb", output);
        }
    }
}
