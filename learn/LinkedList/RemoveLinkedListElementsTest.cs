using Xunit;

namespace leetcode.learn.LinkedList
{
    public class RemoveLinkedListElementsTest
    {
        public class RemoveNthNodeFromEndOfListTest
        {
            [Fact]
            public void Remove_Nth_Node_From_End_Of_List_Test_1()
            {
                var nthNodeFromEndOfList = new RemoveLinkedListElements();

                var node1 = new ListNode(1);
                var node2 = new ListNode(2);
                var node3 = new ListNode(6);
                var node4 = new ListNode(3);
                var node5 = new ListNode(4);
                var node6 = new ListNode(5);
                var node7 = new ListNode(6);

                node1.next = node2;
                node2.next = node3;
                node3.next = node4;
                node4.next = node5;
                node5.next = node6;
                node6.next = node7;

                var nthFromEnd = nthNodeFromEndOfList.RemoveElements(node1, 6);
                Assert.Equal("12345", Helper.StringGetValues(nthFromEnd));
            }

        }
    }
}
