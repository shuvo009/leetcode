using System.Text;
using Xunit;

namespace leetcode.learn.LinkedList
{
    public class RemoveNthNodeFromEndOfListTest
    {
        [Fact]
        public void Remove_Nth_Node_From_End_Of_List_Test_1()
        {
            var removeNthNodeFromEndOfList = new RemoveNthNodeFromEndOfList();

            var node1 = new ListNode(1);
            var node2 = new ListNode(2);
            var node3 = new ListNode(3);
            var node4 = new ListNode(4);
            var node5 = new ListNode(5);

            node1.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node5;
            
            var nthFromEnd = removeNthNodeFromEndOfList.RemoveNthFromEnd(node1, 2);
            Assert.Equal("1235", Helper.StringGetValues(nthFromEnd));
        }

        [Fact]
        public void Remove_Nth_Node_From_End_Of_List_Test_2()
        {
            var removeNthNodeFromEndOfList = new RemoveNthNodeFromEndOfList();

            var node1 = new ListNode(1);
            
            var nthFromEnd = removeNthNodeFromEndOfList.RemoveNthFromEnd(node1, 1);
            Assert.Equal("", Helper.StringGetValues(nthFromEnd));
        }
        
        [Fact]
        public void Remove_Nth_Node_From_End_Of_List_Test_3()
        {
            var removeNthNodeFromEndOfList = new RemoveNthNodeFromEndOfList();

            var node1 = new ListNode(1);
            var node2 = new ListNode(1);
            node1.next = node2;
            
            var nthFromEnd = removeNthNodeFromEndOfList.RemoveNthFromEnd(node1, 1);
            Assert.Equal("1", Helper.StringGetValues(nthFromEnd));
        }

        [Fact]
        public void Remove_Nth_Node_From_End_Of_List_Test_4()
        {
            var removeNthNodeFromEndOfList = new RemoveNthNodeFromEndOfList();

            var node1 = new ListNode(1);
            var node2 = new ListNode(2);
            var node3 = new ListNode(3);
            var node4 = new ListNode(4);
            var node5 = new ListNode(5);

            node1.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node5;

            var nthFromEnd = removeNthNodeFromEndOfList.RemoveNthFromEnd(node1, 1);
            Assert.Equal("1234", Helper.StringGetValues(nthFromEnd));
        }
    }
}
