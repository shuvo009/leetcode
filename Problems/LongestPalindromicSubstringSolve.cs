using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace leetcode.Problems
{
   // https://leetcode.com/problems/longest-palindromic-substring/
    public class LongestPalindromicSubstringSolve
    {
        [Theory]
        [InlineData("babad", "bab")]
        [InlineData("xyzaaaaaxyz", "aaaaa")]
        [InlineData("cbbd", "bb")]
        [InlineData("a", "a")]
        [InlineData("ac", "a")]
        [InlineData("bb", "bb")]
        [InlineData("", "")]
        public void Longest_palindrome_test(string str, string excepted)
        {
            var result = LongestPalindrome(str);

            Assert.Equal(excepted, result);
        }


        public string LongestPalindrome(string s)
        {
            string palindromic = "";

            for (int i = 0; i < s.Length; i++)
            {
                int leftPointer = i;
                int rightPointer = i;

                while (leftPointer >= 0 && rightPointer < s.Length && s[leftPointer] == s[rightPointer])
                {
                    var newPalindromic = s.Substring(leftPointer, rightPointer - leftPointer + 1);
                    if (newPalindromic.Length > palindromic.Length)
                        palindromic = newPalindromic;

                    leftPointer--;
                    rightPointer++;
                }

                leftPointer = i;
                rightPointer = i + 1;

                while (leftPointer >= 0 && rightPointer < s.Length && s[leftPointer] == s[rightPointer])
                {
                    var newPalindromic = s.Substring(leftPointer, rightPointer - leftPointer + 1);
                    if (newPalindromic.Length > palindromic.Length)
                        palindromic = newPalindromic;

                    leftPointer--;
                    rightPointer++;
                }
            }

            return palindromic;
        }
    }
}
