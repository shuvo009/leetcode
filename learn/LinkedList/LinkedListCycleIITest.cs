using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace leetcode.learn.LinkedList
{
    public class LinkedListCycleIITest
    {
        [Fact]
        public void Linked_List_Cycle_Test_II_1()
        {
            var linkedListCycle = new LinkedListCycleII();
            var head = new ListNode(3);
            var node2 = new ListNode(2);
            head.next = node2;

            var node3 = new ListNode(0);
            node2.next = node3;

            var node4 = new ListNode(-4);
            node3.next = node4;
            node4.next = node2;

            var output = linkedListCycle.DetectCycle(head);
            Assert.Equal(output, node2);
        }

        [Fact]
        public void Linked_List_Cycle_Test_II_2()
        {
            var linkedListCycle = new LinkedListCycleII();
            var head = new ListNode(1);
            var node2 = new ListNode(2);
            head.next = node2;
            node2.next = head;

            var output = linkedListCycle.DetectCycle(head);
            Assert.Equal(output, head);
        }

        [Fact]
        public void Linked_List_Cycle_Test_II_3()
        {
            var linkedListCycle = new LinkedListCycleII();
            var head = new ListNode(1);

            var output = linkedListCycle.DetectCycle(head);
            Assert.Null(output);
        }
    }
}
