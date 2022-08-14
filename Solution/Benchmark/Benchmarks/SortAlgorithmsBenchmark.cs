using Algorithms_Data_Structures.DataStructures.Selection_Sort_Algorithm;
using BenchmarkDotNet.Attributes;

namespace Benchmark.Benchmarks
{
    /*
        |         Method |      Mean |    Error |   StdDev |
        |--------------- |----------:|---------:|---------:|
        |           Sort |  41.20 ns | 0.947 ns | 1.197 ns |
        | Sort_Solution2 | 215.91 ns | 4.330 ns | 6.868 ns |
    */

    public class SortAlgorithmsBenchmark
    {
        private int[] input = new int[] { 64, 25, 25, 12, 22, 11, 25 };

        [Benchmark]
        public int[] Sort() => SortAlgorithms.SelectionSort(input);

        [Benchmark]
        public int[] Sort_Solution2() => SortAlgorithms.SelectionSort_Solution2(input);
    }
}
