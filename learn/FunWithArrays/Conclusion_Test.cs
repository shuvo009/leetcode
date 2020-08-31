using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace leetcode.learn.FunWithArrays
{
    public class Conclusion_Test
    {
        [Fact]
        public void Remove_Element_Test()
        {
            var conclusion = new Conclusion();

            var chageCount = conclusion.HeightChecker(new int[] { 1, 1, 4, 2, 1, 3 });
            Assert.Equal(3, chageCount);
            
            chageCount = conclusion.HeightChecker(new int[] { 5, 1, 2, 3, 4 });
            Assert.Equal(5, chageCount);
            
            chageCount = conclusion.HeightChecker(new int[] { 1, 2, 3, 4, 5 });
            Assert.Equal(0, chageCount);

        }
    }
}
