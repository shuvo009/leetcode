using Xunit;

namespace leetcode.learn.FunWithArrays
{
    public class introduction_test
    {
        [Fact]
        public void Find_Max_Consecutive_Ones_Test()
        {
            var introduction = new Introduction();

            var maxConsecutive = introduction.FindMaxConsecutiveOnes(new int[] { 1, 1, 0, 1, 1, 1 });
            Assert.Equal(3, maxConsecutive);

            maxConsecutive = introduction.FindMaxConsecutiveOnes(new int[] { 1, 1, 1, 0, 1, 0, 0 });
            Assert.Equal(3, maxConsecutive);

            maxConsecutive = introduction.FindMaxConsecutiveOnes(new int[] { 0, 0, 0, 0, 0, 0, 0 });
            Assert.Equal(0, maxConsecutive);

            maxConsecutive = introduction.FindMaxConsecutiveOnes(new int[] { 0, 0, 0, 1, 0, 1, 0 });
            Assert.Equal(1, maxConsecutive);

            maxConsecutive = introduction.FindMaxConsecutiveOnes(new int[] { 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1 });
            Assert.Equal(6, maxConsecutive);

        }
        
        
        [Fact]
        public void Find_Numbers_With_Even_Number_Of_Digits_Test()
        {
            var introduction = new Introduction();

            var evenDigitsCount = introduction.FindNumbersWithEvenNumberOfDigits(new int[] { 12, 345, 2, 6, 7896 });
            Assert.Equal(2, evenDigitsCount);
            
            evenDigitsCount = introduction.FindNumbersWithEvenNumberOfDigits(new int[] { 555, 901, 482, 1771 });
            Assert.Equal(1, evenDigitsCount);
            
            evenDigitsCount = introduction.FindNumbersWithEvenNumberOfDigits(new int[] { 555, 901, 482, 14771 });
            Assert.Equal(0, evenDigitsCount);

        }
    }
}
