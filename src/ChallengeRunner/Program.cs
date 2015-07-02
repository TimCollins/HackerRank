using System;
using Algorithms;
using Utils;

namespace ChallengeRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new LibraryFine().SolveIt());
            ConsoleUtils.WaitForEscape();
        }
    }
}
