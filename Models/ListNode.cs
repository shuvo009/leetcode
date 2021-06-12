using System.Text;

namespace leetcode.Models
{
    public class ListNode
    {
        public ListNode next;
        public int val;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public override string ToString()
        {
            StringBuilder sb = new();
            sb.Append(val);

            ListNode nextNode = this.next;
            while (nextNode!=null)
            {
                sb.Append(nextNode.val);
                nextNode = nextNode.next;
            }

            return sb.ToString();
        }
    }
}