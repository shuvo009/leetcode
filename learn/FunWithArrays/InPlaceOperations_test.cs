using Xunit;

namespace leetcode.learn.FunWithArrays
{
    public class InPlaceOperations_test
    {
        [Fact]
        public void Replace_Elements_With_Greatest_Element_On_Right_Side()
        {
            var itemsIntoAnArray = new InPlaceOperations();

            var testInputOne = new int[] { 17, 18, 5, 4, 6, 1 };
            itemsIntoAnArray.ReplaceElementsWithGreatestElementOnRightSide(testInputOne);
            Assert.Equal(new int[] { 18, 6, 6, 6, 1, -1 }, testInputOne);

        }

        [Fact]
        public void Move_Zeroes()
        {
            var itemsIntoAnArray = new InPlaceOperations();

            var testInputOne = new int[] { 0, 1, 0, 3, 12 };
            itemsIntoAnArray.MoveZeroes(testInputOne);
            Assert.Equal(new int[] { 1, 3, 12, 0, 0 }, testInputOne);

            var testInputTwo = new int[] { 1, 1, 3, 3, 12 };
            itemsIntoAnArray.MoveZeroes(testInputTwo);
            Assert.Equal(new int[] { 1, 1, 3, 3, 12 }, testInputTwo);

            var testInputThree = new int[] { 0, 0, 0 };
            itemsIntoAnArray.MoveZeroes(testInputThree);
            Assert.Equal(new int[] { 0, 0, 0 }, testInputThree);

            var testInputFour = new int[] { 1 };
            itemsIntoAnArray.MoveZeroes(testInputFour);
            Assert.Equal(new int[] { 1 }, testInputFour);

            var testInputFive = new int[] { 2, 1 };
            itemsIntoAnArray.MoveZeroes(testInputFive);
            Assert.Equal(new int[] { 2, 1 }, testInputFive);

            var testInputSix = new int[] { 1, 0, 1 };
            itemsIntoAnArray.MoveZeroes(testInputSix);
            Assert.Equal(new int[] { 1, 1, 0 }, testInputSix);

        }
    }
}
