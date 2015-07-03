using System;
using System.Linq;
using Domain.Implementation;
using Domain.Interfaces;

namespace Algorithms
{
    public class CaesarCipher
    {
        private readonly IConsoleReader _reader;
        private readonly char[] _punctuation = "!\"#$%&'()*+'-./:;<=>?`{|}~[\\]^_".ToCharArray();
        private readonly char[] _numbers = "0123456789".ToCharArray();

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

            //var source = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            var inputChars = input.ToCharArray();

            for (int i = 0; i < length; i++)
            {
                char c = inputChars[i];
                if (_punctuation.Contains(c) || _numbers.Contains(c))
                {
                    continue;
                }

                inputChars[i]++;
                inputChars[i]++;
            }

            return new string(inputChars);
        }
    }
}
