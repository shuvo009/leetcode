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
    }
}
