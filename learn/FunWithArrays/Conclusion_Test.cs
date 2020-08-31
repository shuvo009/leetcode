using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace leetcode.learn.FunWithArrays
{
    public class Conclusion_Test
    {
        [Fact]
        public void Height_Checker()
        {
            var conclusion = new Conclusion();

            var chageCount = conclusion.HeightChecker(new int[] { 1, 1, 4, 2, 1, 3 });
            Assert.Equal(3, chageCount);
            
            chageCount = conclusion.HeightChecker(new int[] { 5, 1, 2, 3, 4 });
            Assert.Equal(5, chageCount);
            
            chageCount = conclusion.HeightChecker(new int[] { 1, 2, 3, 4, 5 });
            Assert.Equal(0, chageCount);

        }
        
        
        [Fact]
        public void Third_Maximum_Number()
        {
            var conclusion = new Conclusion();

            var result = conclusion.ThirdMax(new int[] { 3, 2, 1 });
            Assert.Equal(1, result);
            
            result = conclusion.ThirdMax(new int[] { 1, 2 });
            Assert.Equal(2, result);
            
            result = conclusion.ThirdMax(new int[] { 2, 2, 3, 1 });
            Assert.Equal(1, result);

            result = conclusion.ThirdMax(new int[] { 5 });
            Assert.Equal(5, result);
            
            result = conclusion.ThirdMax(new int[] { 1, 1, 2 });
            Assert.Equal(2, result);

        }
    }
}
