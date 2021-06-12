using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using leetcode.learn.LinkedList;
using Xunit;
using ListNode = leetcode.Models.ListNode;

namespace leetcode.Problems
{
    //https://leetcode.com/problems/add-two-numbers/
    public class AddTwoNumbersSolve
    {
        [Fact]
        public void Test_one()
        {
            var node1 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))))));
            var node2 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))));

            var sum = AddTwoNumbers(node1, node2);

            Assert.Equal("89990001", sum.ToString());
        }

        [Fact]
        public void Test_two()
        {
            var node1 = new ListNode(2, new ListNode(4, new ListNode(3)));
            var node2 = new ListNode(5, new ListNode(6, new ListNode(4)));

            var sum = AddTwoNumbers(node1, node2);

            Assert.Equal("708", sum.ToString());
        }


        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var root = new ListNode();

            int carry = 0;
            ListNode node = root;
            while (l1 != null && l2 != null)
            {
                var sum = l1.val + l2.val + carry;

                carry = sum / 10;
                var val = sum % 10;

                node.next = new ListNode(val);


                l1 = l1.next;
                l2 = l2.next;
                node = node.next;
            }

            while (l1 != null)
            {
                var sum = l1.val + carry;
                carry = sum / 10;
                var val = sum % 10;
                node.next = new ListNode(val);


                l1 = l1.next;
                node = node.next;
            }

            while (l2 != null)
            {
                var sum = l2.val + carry;
                carry = sum / 10;
                var val = sum % 10;
                node.next = new ListNode(val);

                l2 = l2.next;
                node = node.next;
            }

            if (carry > 0)
            {
                node.next = new ListNode(carry);
            }

            return root.next;
        }
    }
}
