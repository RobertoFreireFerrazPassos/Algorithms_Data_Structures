using Algorithms_Data_Structures.Algorithms.Selection_Sort_Algorithm;
using BenchmarkDotNet.Attributes;

namespace Benchmark.Benchmarks
{
    /*
        |         Method |      Mean |    Error |    StdDev |
        |--------------- |----------:|---------:|----------:|
        |           Sort |  38.70 ns | 0.897 ns |  0.795 ns |
        | Sort_Solution2 |  37.86 ns | 0.886 ns |  0.948 ns |
        | Sort_Solution3 | 215.55 ns | 4.344 ns | 11.443 ns |
    */

    public class SortAlgorithmsBenchmark
    {
        private int[] input = new int[] { 64, 25, 25, 12, 22, 11, 25 };

        [Benchmark]
        public int[] Sort() => SelectionSort.Sort(input);

        [Benchmark]
        public int[] Sort_Solution2() => SelectionSort.Sort_Solution2(input);

        [Benchmark]
        public int[] Sort_Solution3() => SelectionSort.Sort_Solution3(input);
    }
}
