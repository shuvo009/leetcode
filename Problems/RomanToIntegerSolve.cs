using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace leetcode.Problems
{
    public class RomanToIntegerSolve
    {
        [Theory]
        [InlineData("III", 3)]
        [InlineData("IV", 4)]
        [InlineData("IX", 9)]
        [InlineData("LVIII", 58)]
        [InlineData("MCMXCIV", 1994)]
        public void RomanToIntegerTest(string input, int output)
        {
            var result = RomanToInt(input);
            Assert.Equal(result, output);
        }

        public int RomanToInt(string s)
        {
            var single = new Dictionary<string, int>
            {
                {"I", 1},
                {"V", 5},
                {"X", 10},
                {"L", 50},
                {"C", 100},
                {"D", 500},
                {"M", 1000},
            };
            var doubleRoman = new Dictionary<string, int>
            {
                {"IV", 4},
                {"IX", 9},
                {"XL", 40},
                {"XC", 90},
                {"CD", 400},
                {"CM", 900},
            };

            var sum = 0;
            var charts = s.ToCharArray();

            for (int i = 0; i < charts.Length; i++)
            {
                if (i + 1 < charts.Length)
                {
                    var pair = $"{charts[i]}{charts[i + 1]}";
                    if (doubleRoman.ContainsKey(pair))
                    {
                        sum += doubleRoman[pair];
                        i++;
                        continue;
                    }
                }
                sum += single[charts[i].ToString()];
            }

            return sum;

        }
    }
}
