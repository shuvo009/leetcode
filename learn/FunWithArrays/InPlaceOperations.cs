using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.learn.FunWithArrays
{
    public class InPlaceOperations
    {
        //https://leetcode.com/explore/learn/card/fun-with-arrays/511/in-place-operations/3259/
        public int[] ReplaceElementsWithGreatestElementOnRightSide(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                var maxValue = arr[i + 1];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (maxValue < arr[j])
                        maxValue = arr[j];
                }

                arr[i] = maxValue;
            }

            arr[arr.Length - 1] = -1;
            return arr;
        }

        //https://leetcode.com/explore/learn/card/fun-with-arrays/511/in-place-operations/3157/
        public void MoveZeroes(int[] A)
        {
            var writeIndex = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] != 0)
                    A[writeIndex++] = A[i];
            }

            while (writeIndex < A.Length)
            {
                A[writeIndex++] = 0;
            }
        }


    }
}
