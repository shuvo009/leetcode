﻿namespace leetcode.learn.LinkedList
{
    public class RemoveNthNodeFromEndOfList
    {
        //https://leetcode.com/explore/learn/card/linked-list/214/two-pointer-technique/1296/
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode dummy = new ListNode(0);
            dummy.next = head;
            ListNode first = dummy;
            ListNode second = dummy;
            for (int i = 1; i <= n + 1; i++)
            {
                first = first.next;
            }
            while (first != null)
            {
                first = first.next;
                second = second.next;
            }
            second.next = second.next.next;
            return dummy.next;
        }
    }
}
