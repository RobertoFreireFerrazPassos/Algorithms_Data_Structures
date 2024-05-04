using Algorithms_Data_Structures.BigONotation;
using Xunit;

namespace tests.Algorithms
{
    public class BigONotationTests
    {
        [Theory]
        [InlineData("Lorem Ipsum is simply dummy text of the printing and typesetting", "Lorem Ipsum is simply dummy text of the printing and typestting", false)]
        [InlineData("Lorem Ipsum is simply dummy text of the printing and typesetting", "Lorem Ipsum is simply dummy text of the printing and typesetting", true)]
        [InlineData("Lorem Ipsum is simply dummy text of the printing and typesetting", "Lorem Ipsum is simply dummy text of the printing and typesett1ng", false)]
        [InlineData("A", "A", true)]
        [InlineData("", "", true)]
        [InlineData("", "B", false)]
        [InlineData("CSa", "B", false)]
        public void Sort(string text1, string text2, bool expectedOutput)
        {
            var result = text1.IsEqual(text2);

            Assert.Equal(expectedOutput, result);
        }
    }
}
