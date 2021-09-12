using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace leetcode.Problems
{
    //https://leetcode.com/problems/regular-expression-matching/
    public class RegularExpressionMatchingSolve
    {
        [Theory]
        [InlineData("aa", "a", false)]
        [InlineData("aaa", "aaaa", false)]
        [InlineData("aa", "a*", true)]
        [InlineData("aaaa", "a*", true)]
        [InlineData("ab", ".*", true)]
        [InlineData("abxys", ".*", true)]
        [InlineData("aab", "c*a*b", true)]
        [InlineData("mississippi", "mis*is*p*.", false)]
        [InlineData("ab", ".*c", false)]
        public void Regular_expression_matching_solve(string input, string pattern, bool result)
        {
            var output = IsMatch(input, pattern);
            Assert.Equal(output, result);
        }


        public bool IsMatch(string s, string p)
        {
            var matchLength = 0;
            var patternIndex = 0;
            var inputIndex = 0;
            var currentChar = p[patternIndex];
            var hasStar = false;


            while (patternIndex < p.Length && matchLength < s.Length)
            {
                if (p[patternIndex] == '*')
                {
                    hasStar = true;
                }
                else
                {
                    currentChar = p[patternIndex];
                }


                if (s[inputIndex] == currentChar || currentChar == '.')
                {
                    matchLength++;
                    inputIndex++;
                }
                else
                {
                    hasStar = false;
                }

                if (!hasStar)
                    patternIndex++;
            }

            return matchLength == s.Length && (patternIndex >= p.Length - 1);
        }
    }
}
