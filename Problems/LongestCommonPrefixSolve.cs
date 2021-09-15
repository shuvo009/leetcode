using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace leetcode.Problems
{
    public class LongestCommonPrefixSolve
    {
        [Theory]
        [InlineData(new[] { "flower", "flow", "flight" }, "fl")]
        [InlineData(new[] { "dog", "racecar", "car" }, "")]
        [InlineData(new[] { "", "", "" }, "")]
        [InlineData(new[] { "", "cat", "rat" }, "")]
        [InlineData(new[] { "d", "cat", "rat" }, "")]
        [InlineData(new[] { "d", "dat", "rat" }, "")]
        [InlineData(new[] { "da", "dat", "rat" }, "")]
        [InlineData(new[] { "da", "dat", "dat" }, "da")]
        [InlineData(new[] { "human", "m", "man" }, "")]
        [InlineData(new[] { "human", "woman", "m" }, "")]
        [InlineData(new[] { "name", "name", "name" }, "name")]
        [InlineData(new[] { "ab", "a" }, "a")]
        [InlineData(new[] { "ab" }, "ab")]
        public void LongestCommonPrefixTest(string[] strs, string result)
        {
            var output = LongestCommonPrefix(strs);
            Assert.Equal(result, output);
        }

        public string LongestCommonPrefix(string[] strs)
        {
            var output = "";
            for (int i = 0; i < strs[0].Length; i++)
            {
                var current = strs[0][i];
                for (int j = 1; j < strs.Length; j++)
                {
                    if (i >= strs[j].Length || current != strs[j][i])
                        return output;
                }

                output += current;
            }

            return output;
        }
    }
}
