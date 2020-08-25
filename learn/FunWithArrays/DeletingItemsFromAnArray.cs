using System;

namespace leetcode.learn.FunWithArrays
{
    public class DeletingItemsFromAnArray
    {
        public int RemoveElement(int[] nums, int val)
        {
            var length = nums.Length;
            var arraryLength = nums.Length - 1;
            for (int i = arraryLength; i >= 0; i--)
            {
                if (nums[i] == val)
                {
                    if (i != arraryLength)
                    {
                        for (int j = i; j < nums.Length - 1; j++)
                        {
                            nums[j] = nums[j + 1];
                        }
                    }

                    nums[nums.Length - 1] = 0;
                    length--;
                }

            }

            return length;
        }

        public int RemoveDuplicates(int[] nums)
        {
            var length = nums.Length;
            var arraryLength = nums.Length - 1;
            for (int i = arraryLength; i >= 1; i--)
            {
                if (nums[i] == nums[i - 1])
                {
                    if (i != arraryLength)
                    {
                        for (int j = i; j < nums.Length - 1; j++)
                        {
                            nums[j] = nums[j + 1];
                        }
                    }

                    nums[nums.Length - 1] = 0;
                    length--;
                }

            }

            return length;
        }
    }
}
