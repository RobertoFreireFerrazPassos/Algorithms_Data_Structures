using System;

namespace Algorithms_Data_Structures
{
    public static class Palindrome
    {
        public static bool IsAPalindrome(string input)
        {
            string result = ReverseString.Reverse(input);
            return String.Equals(result, input);
        }
    }
}
