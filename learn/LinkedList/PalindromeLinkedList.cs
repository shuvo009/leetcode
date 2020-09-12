namespace leetcode.learn.LinkedList
{
    public class PalindromeLinkedList
    {
        //https://leetcode.com/explore/learn/card/linked-list/219/classic-problems/1209/
        public bool IsPalindrome(ListNode head)
        {
            if (head == null)
                return true;

            ListNode p = head;
            ListNode prev = new ListNode(head.val);

            while (p.next != null)
            {
                ListNode temp = new ListNode(p.next.val);
                temp.next = prev;
                prev = temp;
                p = p.next;
            }

            ListNode p1 = head;
            ListNode p2 = prev;

            while (p1 != null)
            {
                if (p1.val != p2.val)
                    return false;

                p1 = p1.next;
                p2 = p2.next;
            }

            return true;
        }
    }
}
