using Xunit;

namespace leetcode.Problems
{
    // https://leetcode.com/problems/palindrome-number/
    public class PalindromeNumberSolve
    {
        [Theory]
        [InlineData(121, true)]
        [InlineData(34543, true)]
        [InlineData(48984, true)]
        [InlineData(-121, false)]
        [InlineData(10, false)]
        [InlineData(-101, false)]
        public void Palindrome_test(int input, bool expected)
        {
            var result = IsPalindrome(input);
            Assert.Equal(expected, result);
        }


        public bool IsPalindrome(int x)
        {
            var str = x.ToString();
            int startIndex = 0;
            int endIndex = str.Length - 1;

            while (startIndex < endIndex)
            {
                if (str[startIndex] == str[endIndex])
                {
                    startIndex++;
                    endIndex--;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

    }
}
