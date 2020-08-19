using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace leetcode.learn.FunWithArrays
{
    public class InsertingItemsIntoAnArray_test
    {
        [Fact]
        public void Duplicate_Zeros_Test()
        {
            var insertingItemsIntoAnArray = new InsertingItemsIntoAnArray();


            var testInputOne = new int[] { 1, 0, 2, 3, 0, 4, 5, 0 };
            insertingItemsIntoAnArray.DuplicateZeros(testInputOne);
            Assert.Equal(new int[] { 1, 0, 0, 2, 3, 0, 0, 4 }, testInputOne);
            
            
            var testInputTwo = new int[] { 1, 2, 3 };
            insertingItemsIntoAnArray.DuplicateZeros(testInputTwo);
            Assert.Equal(new int[] { 1, 2, 3 }, testInputTwo);
            
            var testInputThree = new int[] { 0, 0, 0, 0, 0, 0, 0 };
            insertingItemsIntoAnArray.DuplicateZeros(testInputThree);
            Assert.Equal(new int[] { 0, 0, 0, 0, 0, 0, 0 }, testInputThree);

        }
    }
}
