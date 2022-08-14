using Algorithms_Data_Structures.DataStructures.Selection_Sort_Algorithm;
using tests.Extension;
using Xunit;

namespace tests
{
    public class SelectionSortAlgorithmTest
    {
        [Theory]
        [InlineData("64, 25, 25, 12, 22, 11, 25", "11, 12, 22, 25, 25, 25, 64")]
        public void Sort(string array, string expectedOutput)
        {
            var result = SortAlgorithms.SelectionSort(array.CreateIntArray());

            Assert.Equal(expectedOutput, result.CreateString());
        }
    }
}
