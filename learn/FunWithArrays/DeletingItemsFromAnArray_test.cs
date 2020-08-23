using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace leetcode.learn.FunWithArrays
{
    public class DeletingItemsFromAnArray_test
    {
        [Fact]
        public void Remove_Element_Test()
        {
            var deletingItemsFromAnArray = new DeletingItemsFromAnArray();

            var inputOne = new int[] { 3, 2, 2, 3 };
            var length = deletingItemsFromAnArray.RemoveElement(inputOne, 3);
            Assert.Equal(2, length);
            Assert.Equal(inputOne, new int[] { 2, 2, 0, 0 });

            var inputTwo = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
            length = deletingItemsFromAnArray.RemoveElement(inputTwo, 2);
            Assert.Equal(5, length);
            Assert.Equal(inputTwo, new int[] { 0, 1, 3, 0, 4, 0, 0, 0 });

            var inputThree = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
            length = deletingItemsFromAnArray.RemoveElement(inputThree, 9);
            Assert.Equal(8, length);
            Assert.Equal(inputThree, new int[] { 0, 1, 2, 2, 3, 0, 4, 2 });

            var inputFour = new int[] { 0, 0, 0, 0 };
            length = deletingItemsFromAnArray.RemoveElement(inputFour, 0);
            Assert.Equal(0, length);

        }
    }
}
