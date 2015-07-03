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

                int pos = (Convert.ToInt32(inputChars[i]));
                if ((pos > 97 && pos < 123) && (pos + factor > 122))
                {
                    // If the letter is within the range for lower-case letters
                    // and incrementing it would bring it outside
                    // Then increment to the end and then wrap around.
                    int wrapFactor = (pos + factor - 123);
                    inputChars[i] = (char) (Convert.ToInt32('a') + wrapFactor);
                }
                else if ((pos > 65 && pos < 91) && (pos + factor > 90))
                {
                    int wrapFactor = (pos + factor - 91);
                    inputChars[i] = (char)(Convert.ToInt32('A') + wrapFactor);
                }
                else
                {
                    inputChars[i] = (char)(Convert.ToInt32(inputChars[i]) + factor);    
                }
            }

            return new string(inputChars);
        }
    }
}
