using Xunit;

namespace leetcode.learn.LinkedList
{
    public class MergeTwoSortedListsTest
    {
        [Fact]
        public void Merge_Two_Sorted_Lists_Test_1()
        {
            var mergeTwoSortedLists = new MergeTwoSortedLists();

            var node11 = new ListNode(1);
            var node12 = new ListNode(2);
            var node13 = new ListNode(4);

            var node21 = new ListNode(1);
            var node22 = new ListNode(3);
            var node23 = new ListNode(4);

            node11.next = node12;
            node12.next = node13;

            node21.next = node22;
            node22.next = node23;

            var mergeTwoLists = mergeTwoSortedLists.MergeTwoLists(node11, node21);
            Assert.Equal("112344", Helper.StringGetValues(mergeTwoLists));
        }
    }
}
