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
    }
}
