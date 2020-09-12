using Xunit;

namespace leetcode.learn.LinkedList
{
    public class PalindromeLinkedListTest
    {
        [Fact]
        public void Palindrome_Linked_List_Test_1()
        {
            var palindromeLinkedList = new PalindromeLinkedList();

            var node1 = new ListNode(1);
            var node2 = new ListNode(2);
            
            node1.next = node2;

            var result = palindromeLinkedList.IsPalindrome(node1);
            Assert.False(result);
        }
        
        [Fact]
        public void Palindrome_Linked_List_Test_2()
        {
            var palindromeLinkedList = new PalindromeLinkedList();

            var node1 = new ListNode(1);
            var node2 = new ListNode(2);
            var node3 = new ListNode(2);
            var node4 = new ListNode(1);
            
            node1.next = node2;
            node2.next = node3;
            node3.next = node4;

            var result = palindromeLinkedList.IsPalindrome(node1);
            Assert.True(result);
        }
    }
}