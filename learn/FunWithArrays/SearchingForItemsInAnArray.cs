using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.learn.FunWithArrays
{
    public class SearchingForItemsInAnArray
    {
        //https://leetcode.com/explore/learn/card/fun-with-arrays/527/searching-for-items-in-an-array/3250/
        public bool CheckIfNAndItsDoubleExist(int[] arr)
        {
            var hashTable = new HashSet<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                var value = arr[i];
                var doubleValue = value * 2;
                if (hashTable.Contains(doubleValue) || (value % 2 == 0 && hashTable.Contains(value / 2)))
                    return true;

                hashTable.Add(value);
            }

            return false;
        }

        //https://leetcode.com/explore/learn/card/fun-with-arrays/527/searching-for-items-in-an-array/3251/
        public bool ValidMountainArray(int[] A)
        {
            var isDownhillStarted = false;
            var isUphillStarted = false;
            for (int i = 0; i < A.Length - 1; i++)
            {
                if (A[i] > A[i + 1])
                {
                    isDownhillStarted = true;
                }
                else
                {
                    isUphillStarted = true;
                    if (isDownhillStarted)
                        return false;
                }
            }

            return isUphillStarted && isDownhillStarted;
        }

    }
}
