using System;
using BenchmarkDotNet.Attributes;
using Algorithms_Data_Structures;

namespace Benchmark.Benchmarks
{
    public class ReverseStringBenchmark
    {
        private const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        private string input;
        private int inputLength = 100;

        public ReverseStringBenchmark()
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
        public string Reverse() => ReverseString.Reverse(input);

        [Benchmark]
        public string Reverse_solution2() => ReverseString.Reverse_solution2(input);
    }
}
