using Algorithms_Data_Structures.Algorithms.Sort;
using tests.Extension;
using Xunit;

namespace tests.Algorithms
{
    public class QuickSortTest
    {
        [Theory]
        [InlineData("64, 25, 25, 12, 22, 11, 25", "11, 12, 22, 25, 25, 25, 64")]
        [InlineData("64, 25, 12, 22, 11, 25", "11, 12, 22, 25, 25, 64")]
        [InlineData("1, 25, 7, 25, 12, 22, 11, 70", "1, 7, 11, 12, 22, 25, 25, 70")]
        [InlineData("11, 5", "5, 11")]
        [InlineData("3", "3")]
        [InlineData("3, 5", "3, 5")]
        [InlineData("1, 2, 3", "1, 2, 3")]
        [InlineData("3, 2, 1", "1, 2, 3")]
        [InlineData("3, 0, 3", "0, 3, 3")]
        public void Sort(string array, string expectedOutput)
        {
            var result = QuickSort.Sort(array.CreateIntArray());

            Assert.Equal(expectedOutput, result.CreateString());
        }
    }
}
