using System.Text;

namespace leetcode.learn.LinkedList
{
    public static class Helper
    {
        public static string StringGetValues(ListNode listNode)
        {
            if (listNode == null)
                return "";

            var currentNode = listNode;
            var sb = new StringBuilder();
            while (currentNode != null)
            {
                sb.Append(currentNode.val);
                currentNode = currentNode.next;
            }

            return sb.ToString();
        }
    }
}