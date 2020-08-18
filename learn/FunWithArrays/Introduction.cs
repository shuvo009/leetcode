using System;

namespace leetcode.learn.FunWithArrays
{
    public class Introduction
    {
        //Given a binary array, find the maximum number of consecutive 1s in this array.

        //Input: [1,1,0,1,1,1]
        //Output: 3
        //Explanation: The first two digits or the last three digits are consecutive 1s. The maximum number of consecutive 1s is 3.

        public int FindMaxConsecutiveOnes(int[] nums)
        {
            var globalMax = 0;
            var localMax = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    localMax++;
                }
                else
                {
                    globalMax = Math.Max(globalMax, localMax);
                    localMax = 0;
                }
            }

            return Math.Max(globalMax, localMax);
        }

        //Given an array nums of integers, return how many of them contain an even number of digits.

        public int FindNumbersWithEvenNumberOfDigits(int[] nums)
        {
            var evenDigiteCount = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                var digiteCount = nums[i].ToString().ToCharArray().Length;
                if (digiteCount % 2 == 0)
                    evenDigiteCount++;
            }

            return evenDigiteCount;
        }

    }
}