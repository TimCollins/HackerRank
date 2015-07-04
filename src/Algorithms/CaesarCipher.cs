using System;
using System.Linq;
using System.Security.Policy;
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

                if (Char.IsLower(c))
                {
                    int currentPos = Array.IndexOf(_lowerCaseAlphabet, c);
                    int newPos = currentPos + factor;

                    if (newPos > _lowerCaseAlphabet.Length - 1)
                    {
                        newPos = newPos % _lowerCaseAlphabet.Length;
                    }

                    inputChars[i] = _lowerCaseAlphabet[newPos];
                }
                else
                {
                    int currentPos = Array.IndexOf(_upperCaseAlphabet, c);
                    int newPos = currentPos + factor;

                    if (newPos > _upperCaseAlphabet.Length - 1)
                    {
                        newPos = newPos % _upperCaseAlphabet.Length;
                    }

                    inputChars[i] = _upperCaseAlphabet[newPos];
                }
            }

            return new string(inputChars);
        }
    }
}
