using System;
using System.Collections.Generic;
using Xunit;

namespace leetcode.Problems
{
    //https://leetcode.com/problems/median-of-two-sorted-arrays/
    public class MedianOfTwoSortedArraysSolve
    {
        [Theory]
        [InlineData(new[] { 1, 3 }, new[] { 2 }, 2.00000D)]
        [InlineData(new[] { 1, 2 }, new[] { 3, 4 }, 2.50000D)]
        [InlineData(new[] { 0, 0 }, new[] { 0, 0 }, 0.00000D)]
        [InlineData(new int[] { }, new[] { 1 }, 1.00000D)]
        [InlineData(new[] { 2 }, new int[] { }, 2.00000D)]
        [InlineData(new[] { 1, 3 }, new[] { 2, 7 }, 2.50000D)]
        public void Find_median_sorted_arrays(int[] nums1, int[] nums2, double expected)
        {
            var result = FindMedianSortedArrays(nums1, nums2);

            Assert.Equal(expected, result);
        }


        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var nums = new List<int>();
            nums.AddRange(nums1);
            nums.AddRange(nums2);
            nums.Sort();
            
            var length = nums.Count;
            
            double medianValue = 0;
            var md = length / 2;
            if (length % 2 == 1)
                medianValue = nums[length / 2];
            else
            {
                medianValue = Math.Abs(((double)nums[md - 1] + (double)nums[md]) / (double)2);
            }
            
            return medianValue;
        }
    }
}
