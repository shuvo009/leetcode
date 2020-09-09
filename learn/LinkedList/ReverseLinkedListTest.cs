using Xunit;

namespace leetcode.learn.LinkedList
{
    public class ReverseLinkedListTest
    {
        [Fact]
        public void Remove_Nth_Node_From_End_Of_List_Test_1()
        {
            var reverseLinkedList = new ReverseLinkedList();

            var node1 = new ListNode(1);
            var node2 = new ListNode(2);
            var node3 = new ListNode(3);
            var node4 = new ListNode(4);
            var node5 = new ListNode(5);

            node1.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node5;

            var nthFromEnd = reverseLinkedList.ReverseList(node1);
            Assert.Equal("54321", Helper.StringGetValues(nthFromEnd));
        }
    }
}