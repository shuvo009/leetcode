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
    }
}
