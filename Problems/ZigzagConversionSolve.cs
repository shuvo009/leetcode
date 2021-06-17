using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace leetcode.Problems
{
    public class ZigzagConversionSolve
    {
        [Theory]
        [InlineData("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
        public void Zigzag_conversion_test(string input, int row, string expected)
        {
            var result = Convert(input, row);
            Assert.Equal(expected, result);
        }

        public string Convert(string s, int numRows)
        {
            var length = s.Length;
            var cycleLen = numRows * 2 - 2;
            var sb = new StringBuilder();

            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j + i < length; j += cycleLen)
                {
                    sb.Append(s[i + j]);
                    if (i != 0 && i != numRows - 1 && j + cycleLen - i < length)
                        sb.Append(s[j + cycleLen - i]);
                }
            }

            return sb.ToString();
        }
    }
}
