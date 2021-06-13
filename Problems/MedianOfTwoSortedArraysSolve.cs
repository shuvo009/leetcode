using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace leetcode.Problems
{
    public class MedianOfTwoSortedArraysSolve
    {
        [Theory]
        [InlineData(new[] { 1, 3 }, new[] { 2 }, 2.00000D)]
        [InlineData(new[] { 1,2 }, new[] { 3,4 }, 2.50000D)]
        [InlineData(new[] { 0,0 }, new[] { 0,0 }, 0.00000D)]
        [InlineData(new int[] {  }, new[] { 1 }, 1.00000D)]
        [InlineData(new [] { 2 }, new int[] { }, 2.00000D)]
        [InlineData(new [] { 1,3 }, new [] { 2,7}, 2.50000D)]
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

            var sum = nums.Sum();
            var median = (double)sum / nums.Count;

            return median;
        }
    }
}
