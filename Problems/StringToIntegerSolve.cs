using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace leetcode.Problems
{
    //https://leetcode.com/problems/string-to-integer-atoi/
    public class StringToIntegerSolve
    {
        [Theory]
        [InlineData("42", 42)]
        [InlineData("   -42", -42)]
        [InlineData("4193 with words", 4193)]
        [InlineData("words and 987", 0)]
        [InlineData("-91283472332", -2147483648)]
        [InlineData("91283472332", 2147483647)]
        [InlineData("3.14159", 3)]
        [InlineData("+-12", 0)]
        [InlineData("-+12", 0)]
        [InlineData("12+-", 12)]
        [InlineData("   +0 123", 0)]
        public void MyAtoi_test(string input, int expected)
        {
            var result = MyAtoi(input);
            Assert.Equal(expected, result);
        }


        public int MyAtoi(string s)
        {
            var digits = new List<char>();
            foreach (var a in s.TrimStart())
            {
                if ((a == '-' || a == '+') && digits.Count > 0)
                    break;


                if ((char.IsLetter(a) || char.IsPunctuation(a) || char.IsSeparator(a)) && a != '-')
                    break;

                digits.Add(a);
            }

            if (!digits.Any())
                return 0;

            var str = new string(digits.ToArray());

            if (int.TryParse(str, out var x))
                return x;

            if (digits.Count < 2)
                return 0;

            return digits[0] == '-' ? int.MinValue : int.MaxValue;
        }
    }
}