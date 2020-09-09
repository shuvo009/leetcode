namespace leetcode.learn.LinkedList
{
    public class ReverseLinkedList
    {
        //https://leetcode.com/explore/learn/card/linked-list/219/classic-problems/1205/
        public ListNode ReverseList(ListNode head)
        {
            ListNode prevNode = null;
            var current = head;

            while (current != null)
            {
                var nextNode = current.next;
                current.next = prevNode;

                prevNode = current;
                current = nextNode;
            }

            head = prevNode;
            return head;
        }
    }
}
