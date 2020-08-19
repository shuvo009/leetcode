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

        [Fact]
        public void Merge_Sorted_Array_Test()
        {
            var insertingItemsIntoAnArray = new InsertingItemsIntoAnArray();


            var test1_num1 = new int[] { 1, 2, 3, 0, 0, 0 };
            var test1_num2 = new int[] { 2, 5, 6 };
            insertingItemsIntoAnArray.MergeSortedArray(test1_num1, 3, test1_num2, 3);
            Assert.Equal(new int[] { 1, 2, 2, 3, 5, 6 }, test1_num1);
        }
    }
}
