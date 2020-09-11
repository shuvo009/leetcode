using System.Security.Cryptography;

namespace leetcode.learn.LinkedList
{
    public class OddEvenLinkedList
    {
        //https://leetcode.com/explore/learn/card/linked-list/219/classic-problems/1208/
        public ListNode OddEvenList(ListNode head)
        {
            if (head == null)
                return head;
            ListNode result = head;
            ListNode tempNode1 = head;
            ListNode tempNode2 = head.next;
            ListNode connectedNode = head.next;
            while (tempNode1 != null && tempNode2 != null)
            {
                if (tempNode2.next == null)
                    break;
                tempNode1.next = tempNode2.next;
                tempNode1 = tempNode1.next;

                tempNode2.next = tempNode1.next;
                tempNode2 = tempNode2.next;
            }

            tempNode1.next = connectedNode;
            return result;
        }
    }
}