using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace leetcode.Problems
{
    //https://leetcode.com/problems/reverse-integer/
    public class ReverseIntegerSolve
    {
        [Theory]
        [InlineData(123, 321)]
        [InlineData(-123, -321)]
        [InlineData(120, 21)]
        [InlineData(0, 0)]
        [InlineData(-10, -1)]
        [InlineData(10, 1)]
        [InlineData(1534236469, 0)]
        public void Reverse_integer_test(int input, int expected)
        {
            var result = Reverse(input);
            Assert.Equal(expected, result);
        }

        public int Reverse(int x)
        {
            var st = x.ToString().ToCharArray();
            if (st.Length < 1)
                return x;

            var index = st[0] == '-' ? 1 : 0;
            var lastIndex = st.Length - 1;

            while (index <= lastIndex)
            {
                var temp = st[index];
                st[index] = st[lastIndex];
                st[lastIndex] = temp;
                index++;
                lastIndex--;
            }
            var num = new string(st);
            Int32.TryParse(num, out var output);

            return output;
        }
    }
}
