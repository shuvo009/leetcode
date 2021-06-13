using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace leetcode.Problems
{
    //https://leetcode.com/problems/longest-substring-without-repeating-characters/
    public class LengthOfLongestSubstringSolve
    {
        [Theory]
        [InlineData("abcabcbb", 3)]
        [InlineData("bbbbb", 1)]
        [InlineData("", 0)]
        [InlineData("pwwkew", 3)]
        [InlineData("dvdf", 3)]
        public void Length_of_longest_substring_Test(string str, int result)
        {
            var count = LengthOfLongestSubstring(str);

            Assert.Equal(result, count);
        }


        public int LengthOfLongestSubstring(string s)
        {
            var set = new Dictionary<char, int>();
            var maxSubString = 0;
            var slidingWindowIndex = 0;
            

            for (int i = 0; i < s.Length; i++)
            {
                var c = s[i];
                while (set.ContainsKey(c))
                {
                    set.Remove(s[slidingWindowIndex]);
                    slidingWindowIndex++;
                }
                set.Add(c, 1);
                var length = i - slidingWindowIndex + 1;


                maxSubString = Math.Max(maxSubString, length);
            }



            return maxSubString;
        }
    }
}
