using Algorithms_Data_Structures;
using BenchmarkDotNet.Attributes;
using System;

namespace Benchmark.Benchmarks
{
    public class PalindromeBenchmark
    {
        private const string chars = "AB";
        private string input;
        private int inputLength = 4;

        public PalindromeBenchmark()
        {

            var stringChars = new char[inputLength];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            input = new String(stringChars);
        }

        [Benchmark]
        public bool IsAPalindrome() => Palindrome.IsAPalindrome(input);

        [Benchmark]
        public bool IsAPalindrome_solution2() => Palindrome.IsAPalindrome_solution2(input);
    }
}
