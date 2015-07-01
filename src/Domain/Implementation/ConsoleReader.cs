using System;
using Domain.Interfaces;

namespace Domain.Implementation
{
    public class ConsoleReader : IConsoleReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }

        public int Read()
        {
            return Console.Read();
        }
    }
}
