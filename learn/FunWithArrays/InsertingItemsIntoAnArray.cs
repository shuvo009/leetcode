using System;
using System.Linq;

namespace leetcode.learn.FunWithArrays
{
    public class InsertingItemsIntoAnArray
    {
        //https://leetcode.com/explore/learn/card/fun-with-arrays/525/inserting-items-into-an-array/3245/
        public void DuplicateZeros(int[] arr)
        {
            int currentIndex = 0;
            while (currentIndex < arr.Length)
            {
                if (arr[currentIndex] == 0)
                {
                    for (int i = arr.Length - 2; i > currentIndex; i--)
                        arr[i + 1] = arr[i];

                    if (++currentIndex <= arr.Length - 1)
                        arr[currentIndex] = 0;
                }

                currentIndex++;
            }
        }

        //https://leetcode.com/explore/learn/card/fun-with-arrays/525/inserting-items-into-an-array/3253/
        public void MergeSortedArray(int[] nums1, int m, int[] nums2, int n)
        {
            for (int i = 0; i < n; i++)
                nums1[m + i] = nums2[i];

            Array.Sort(nums1);
        }
    }
}
