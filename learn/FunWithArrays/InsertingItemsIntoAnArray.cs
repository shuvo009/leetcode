namespace leetcode.learn.FunWithArrays
{
    public class InsertingItemsIntoAnArray
    {
        public void DuplicateZeros(int[] arr)
        {
            int curentIndex = 0;
            while (curentIndex < arr.Length)
            {
                if (arr[curentIndex] == 0)
                {
                    for (int i = arr.Length - 2; i > curentIndex; i--)
                        arr[i + 1] = arr[i];

                    if (++curentIndex <= arr.Length - 1)
                        arr[curentIndex] = 0;
                }

                curentIndex++;
            }
        }
    }
}
