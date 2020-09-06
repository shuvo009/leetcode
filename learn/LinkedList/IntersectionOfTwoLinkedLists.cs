using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.learn.LinkedList
{
    public class IntersectionOfTwoLinkedLists
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            HashSet<ListNode> _hashSet = new HashSet<ListNode>();

            var current = headA;
            while (current != null)
            {
                _hashSet.Add(current);
                current = current.next;
            }

            current = headB;
            while (current != null)
            {
                if (_hashSet.Contains(current))
                    return current;
                _hashSet.Add(current);
                current = current.next;
            }

            return null;
        }
    }
}
