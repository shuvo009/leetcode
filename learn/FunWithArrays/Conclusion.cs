using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.learn.FunWithArrays
{
    public class Conclusion
    {
        //https://leetcode.com/explore/learn/card/fun-with-arrays/523/conclusion/3228/
        public int HeightChecker(int[] heights)
        {
            var targerArray = new int[heights.Length];
            Array.Copy(heights, targerArray, heights.Length);
            Array.Sort(targerArray);

            var setChangeCount = 0;
            for (int i = 0; i < heights.Length; i++)
            {
                if (heights[i] != targerArray[i])
                    setChangeCount++;
            }

            return setChangeCount;
        }

        //https://leetcode.com/explore/learn/card/fun-with-arrays/523/conclusion/3231/
        public int ThirdMax(int[] nums)
        {
            Array.Sort(nums);
            var array = new HashSet<int>(nums).ToArray();
            var index = array.Length > 2 ? array.Length - 3 : array.Length - 1;
            return array[index];
        }
    }
}
