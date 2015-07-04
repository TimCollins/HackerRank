using System;
using System.Linq;
using Domain.Implementation;
using Domain.Interfaces;

namespace Algorithms
{
    public class CaesarCipher
    {
        private readonly IConsoleReader _reader;
        private readonly char[] _punctuation = "!\"#£€$%&'()*+'-./:;<=>?`{|}~[\\]^_@".ToCharArray();
        private readonly char[] _numbers = "0123456789".ToCharArray();
        private readonly char[] _lowerCaseAlphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        private readonly char[] _upperCaseAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

        public CaesarCipher(IConsoleReader reader)
        {
            _reader = reader;
        }

        public CaesarCipher()
        {
            _reader = new ConsoleReader();    
        }

        public string SolveIt()
        {
            int length = Convert.ToInt32(_reader.ReadLine());
            string input = _reader.ReadLine();
            int factor = Convert.ToInt32(_reader.ReadLine());

            var inputChars = input.ToCharArray();

            for (int i = 0; i < length; i++)
            {
                char c = inputChars[i];
                if (_punctuation.Contains(c) || _numbers.Contains(c))
                {
                    continue;
                }

                int currentPos = Char.IsLower(c)
                    ? Array.IndexOf(_lowerCaseAlphabet, c)
                    : Array.IndexOf(_upperCaseAlphabet, c);
                int newPos = currentPos + factor;

                if (newPos > _lowerCaseAlphabet.Length - 1)
                {
                    newPos = newPos % _lowerCaseAlphabet.Length;
                }

                inputChars[i] = Char.IsLower(c) ? _lowerCaseAlphabet[newPos] : _upperCaseAlphabet[newPos];
            }

            return new string(inputChars);
        }
    }
}
