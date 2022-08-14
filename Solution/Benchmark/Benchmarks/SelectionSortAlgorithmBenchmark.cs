using Algorithms_Data_Structures.DataStructures.Selection_Sort_Algorithm;
using BenchmarkDotNet.Attributes;

namespace Benchmark.Benchmarks
{
    public class SortAlgorithmsBenchmark
    {
        private int[] input = new int[] { 64, 25, 25, 12, 22, 11, 25 };

        [Benchmark]
        public int[] Sort() => SortAlgorithms.SelectionSort(input);
    }
}
