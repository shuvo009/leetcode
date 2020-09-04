using Xunit;

namespace leetcode.learn.LinkedList
{
    public class MyLinkedListTest
    {
        [Fact]
        public void My_Linked_List_Test_1()
        {
            var myLinkedList = new MyLinkedList();
            
            myLinkedList.AddAtHead(1);
            
            myLinkedList.AddAtTail(3);
            
            myLinkedList.AddAtIndex(1, 2);
            
            var val = myLinkedList.Get(1);
            Assert.Equal(2, val);
            myLinkedList.DeleteAtIndex(1);
         
            val = myLinkedList.Get(1);
            Assert.Equal(3, val);
        }
        
        
        [Fact]
        public void My_Linked_List_Test_2()
        {
            var myLinkedList = new MyLinkedList();
            
            myLinkedList.AddAtHead(1);
            
            myLinkedList.AddAtTail(3);
            
            myLinkedList.AddAtIndex(1, 2);
            
            var val = myLinkedList.Get(1);
            Assert.Equal(2, val);
            myLinkedList.DeleteAtIndex(0);
         
            val = myLinkedList.Get(0);
            Assert.Equal(2, val);
        }
        
        [Fact]
        public void My_Linked_List_Test_3()
        {
            var myLinkedList = new MyLinkedList();
            
            myLinkedList.AddAtIndex(0, 10);
            myLinkedList.AddAtIndex(0, 20);
            myLinkedList.AddAtIndex(1, 30);
            
            var val = myLinkedList.Get(0);
            Assert.Equal(20, val);
        }
    }
}
