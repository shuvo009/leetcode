using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace leetcode.learn.LinkedList
{
    public class IntersectionOfTwoLinkedListsTest
    {
        [Fact]
        public void Get_Intersection_Node_Test_1()
        {
            var intersectionOfTwoLinkedLists = new IntersectionOfTwoLinkedLists();
            var node1 = new ListNode(4);
            var node2 = new ListNode(1);
            var node3 = new ListNode(8);
            var node4 = new ListNode(4);
            var node5 = new ListNode(5);
            var node6 = new ListNode(5);
            var node7 = new ListNode(6);
            var node8 = new ListNode(1);

            var listA = node1;
            listA.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node5;

            var listB = node6;
            node6.next = node7;
            node7.next = node8;
            node8.next = node3;

            var output = intersectionOfTwoLinkedLists.GetIntersectionNode(listA, listB);
            Assert.Equal(output, node3);
        }
        
        
        [Fact]
        public void Get_Intersection_Node_Test_2()
        {
            var intersectionOfTwoLinkedLists = new IntersectionOfTwoLinkedLists();
            var node1 = new ListNode(1);
            var node2 = new ListNode(9);
            var node3 = new ListNode(1);
            var node4 = new ListNode(2);
            var node5 = new ListNode(4);
            var node6 = new ListNode(3);
            

            var listA = node1;
            listA.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node5;

            var listB = node6;
            node6.next = node4;

            var output = intersectionOfTwoLinkedLists.GetIntersectionNode(listA, listB);
            Assert.Equal(output, node4);
        }
        

        [Fact]
        public void Get_Intersection_Node_Test_3()
        {
            var intersectionOfTwoLinkedLists = new IntersectionOfTwoLinkedLists();
            var node1 = new ListNode(2);
            var node2 = new ListNode(6);
            var node3 = new ListNode(4);

            var node4 = new ListNode(1);
            var node5 = new ListNode(5);

            var listA = node1;
            listA.next = node2;
            node2.next = node3;
            
            var listB = node4;
            node4.next = node5;

            var output = intersectionOfTwoLinkedLists.GetIntersectionNode(listA, listB);
            Assert.Null(output);
        }
    }
}
