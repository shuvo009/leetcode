using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace leetcode.learn.LinkedList
{
    public class LinkedListCycleTest
    {
        [Fact]
        public void Linked_List_Cycle_Test_1()
        {
            var linkedListCycle = new LinkedListCycle();
            var head = new ListNode(3);
            var node2 = new ListNode(2);
            head.next = node2;

            var node3 = new ListNode(0);
            node2.next = node3;

            var node4 = new ListNode(-4);
            node3.next = node4;
            node4.next = node2;

            var output = linkedListCycle.HasCycle(head);
            Assert.True(output);
        }
        
        
        [Fact]
        public void Linked_List_Cycle_Test_2()
        {
            var linkedListCycle = new LinkedListCycle();
            var head = new ListNode(1);
            var node2 = new ListNode(2);
            head.next = node2;
            node2.next = head;

            var output = linkedListCycle.HasCycle(head);
            Assert.True(output);
        }
        
        
        [Fact]
        public void Linked_List_Cycle_Test_3()
        {
            var linkedListCycle = new LinkedListCycle();
            var head = new ListNode(1);
            
            var output = linkedListCycle.HasCycle(head);
            Assert.False(output);
        }

    }
}
