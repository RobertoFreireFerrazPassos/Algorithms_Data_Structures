using Algorithms_Data_Structures;
using Xunit;

namespace tests
{
    public class PalindromeTest
    {
        [Theory]
        [InlineData("aba")]
        [InlineData("1000000001")]
        [InlineData("pennep")]
        public void MustBeAPalindrome(string input)
        {
            bool result = Palindrome.IsAPalindrome(input);
            Assert.True(result);
        }

        [Theory]
        [InlineData(" aba")]
        [InlineData("aba ")]
        [InlineData("greetings")]
        [InlineData("Fish hsif")]
        public void MustNotBeAPalindrome(string input)
        {
            bool result = Palindrome.IsAPalindrome(input);
            Assert.False(result);
        }
    }
}
