namespace leetcode.learn.LinkedList
{
    public class RemoveLinkedListElements
    {
        //https://leetcode.com/explore/learn/card/linked-list/219/classic-problems/1207/
        public ListNode RemoveElements(ListNode head, int val)
        {
            var helperNode = new ListNode(0);
            helperNode.next = head;
            var tempNode = helperNode;

            while (tempNode.next != null)
                if (tempNode.next.val == val)
                    tempNode.next = tempNode.next.next;
                else
                    tempNode = tempNode.next;

            return helperNode.next;
        }
    }
}