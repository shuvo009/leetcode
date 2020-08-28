using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace leetcode.learn.FunWithArrays
{
    public class SearchingForItemsInAnArray_test
    {
        [Fact]
        public void Check_If_N_And_Its_Double_Exist()
        {
            var searchingForItemsInAnArray = new SearchingForItemsInAnArray();

            var exist = searchingForItemsInAnArray.CheckIfNAndItsDoubleExist(new int[] { 10, 2, 5, 3 });
            Assert.True(exist);

            exist = searchingForItemsInAnArray.CheckIfNAndItsDoubleExist(new int[] { 7, 1, 14, 11 });
            Assert.True(exist);

            exist = searchingForItemsInAnArray.CheckIfNAndItsDoubleExist(new int[] { 3, 1, 7, 11 });
            Assert.False(exist);

            exist = searchingForItemsInAnArray.CheckIfNAndItsDoubleExist(new int[] { -2, 0, 10, -19, 4, 6, -8 });
            Assert.False(exist);

            exist = searchingForItemsInAnArray.CheckIfNAndItsDoubleExist(new int[] { 0, 0 });
            Assert.True(exist);
        }

        [Fact]
        public void Valid_Mountain_Array()
        {
            var searchingForItemsInAnArray = new SearchingForItemsInAnArray();
            var isValid = searchingForItemsInAnArray.ValidMountainArray(new int[] {0, 3, 2, 1});
            Assert.True(isValid);
            
            isValid = searchingForItemsInAnArray.ValidMountainArray(new int[] { 3, 5, 5 });
            Assert.False(isValid);
            
            isValid = searchingForItemsInAnArray.ValidMountainArray(new int[] { 2, 1 });
            Assert.False(isValid);
            
            isValid = searchingForItemsInAnArray.ValidMountainArray(new int[] { 1, 2 });
            Assert.False(isValid);
            
            isValid = searchingForItemsInAnArray.ValidMountainArray(new int[] { 1, 1 });
            Assert.False(isValid);
        }
    }
}
