using System;

namespace leetcode.learn.FunWithArrays
{
    public class DeletingItemsFromAnArray
    {
        //https://leetcode.com/explore/learn/card/fun-with-arrays/526/deleting-items-from-an-array/3247/
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

        //https://leetcode.com/explore/learn/card/fun-with-arrays/526/deleting-items-from-an-array/3248/
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
