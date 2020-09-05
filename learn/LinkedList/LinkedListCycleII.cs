using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.learn.LinkedList
{
    public class LinkedListCycleII
    {
        public ListNode DetectCycle(ListNode head)
        {
            HashSet<ListNode> hashSet = new HashSet<ListNode>();
            var current = head;
            while (current != null)
            {
                if (hashSet.Contains(current))
                    return current;
                hashSet.Add(current);
                current = current.next;
            }

            return null;
        }
    }
}
