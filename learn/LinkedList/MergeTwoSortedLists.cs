namespace leetcode.learn.LinkedList
{
    public class MergeTwoSortedLists
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null)
                return l2;
            if (l2 == null)
                return l1;

            ListNode mergedHead = null;

            if (l1.val <= l2.val)
            {
                mergedHead = l1;
                l1 = l1.next;
            }
            else
            {
                mergedHead = l2;
                l2 = l2.next;
            }

            ListNode margedTail = mergedHead;

            while (l1 != null && l2 != null)
            {
                ListNode temp = null;
                if (l1.val <= l2.val)
                {
                    temp = l1;
                    l1 = l1.next;
                }
                else
                {
                    temp = l2;
                    l2 = l2.next;
                }

                margedTail.next = temp;
                margedTail = temp;
            }

            if (l1 != null)
            {
                margedTail.next = l1;
            }
            else if (l2 != null)
            {
                margedTail.next = l2;
            }

            return mergedHead;
        }
    }
}
