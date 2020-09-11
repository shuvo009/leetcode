using Xunit;

namespace leetcode.learn.LinkedList
{
    public class OddEvenLinkedListTest
    {
        [Fact]
        public void Odd_Even_Linked_List_Test_1()
        {
            var oddEvenLinkedList = new OddEvenLinkedList();

            var node1 = new ListNode(1);
            var node2 = new ListNode(2);
            var node3 = new ListNode(3);
            var node4 = new ListNode(4);
            var node5 = new ListNode(5);

            node1.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node5;

            var result = oddEvenLinkedList.OddEvenList(node1);
            Assert.Equal("13524", Helper.StringGetValues(result));
        }
        
        [Fact]
        public void Odd_Even_Linked_List_Test_2()
        {
            var oddEvenLinkedList = new OddEvenLinkedList();

            var node1 = new ListNode(2);
            var node2 = new ListNode(1);
            var node3 = new ListNode(3);
            var node4 = new ListNode(5);
            var node5 = new ListNode(6);
            var node6 = new ListNode(4);
            var node7 = new ListNode(7);

            node1.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node5;
            node5.next = node6;
            node6.next = node7;

            var result = oddEvenLinkedList.OddEvenList(node1);
            Assert.Equal("2367154", Helper.StringGetValues(result));
        }
    }
}