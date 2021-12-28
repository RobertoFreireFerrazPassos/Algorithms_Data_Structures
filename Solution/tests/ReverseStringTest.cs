using Algorithms_Data_Structures;
using Xunit;

namespace tests
{
    public class ReverseStringTest
    {
        [Theory]
        [InlineData("abcd","dcba")]
        [InlineData("  abcd", "dcba  ")]
        public void MustReversesAString(string input, string expectedOutput)
        {
            string result = ReverseString.Reverse(input);
            Assert.Equal(expectedOutput, result);
        }
    }
}