﻿using Benchmark.Benchmarks;
using BenchmarkDotNet.Running;


namespace Benchmark
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<SortAlgorithmsBenchmark>();
        }
    }
}
