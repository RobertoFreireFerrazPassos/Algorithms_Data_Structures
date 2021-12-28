using Algorithms_Data_Structures;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;

/*
    |            Method |       Mean |     Error |    StdDev |
    |------------------ |-----------:|----------:|----------:|
    |           Reverse |   212.4 ns |   9.84 ns |  29.00 ns |
    | Reverse_solution2 | 3,546.5 ns | 114.11 ns | 332.85 ns |
*/

namespace Benchmark
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

    public class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<ReverseStringBenchmark>();
        }
    }
}
