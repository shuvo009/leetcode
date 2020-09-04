using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.learn.LinkedList
{

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }

    public class LinkedListCycle
    {
        public bool HasCycle(ListNode head)
        {
            HashSet<ListNode> hashSet = new HashSet<ListNode>();
            var current = head;
            while (current!=null)
            {
                if (hashSet.Contains(current))
                    return true;
                hashSet.Add(current);
                current = current.next;
            }

            return false;

        }
    }
}
