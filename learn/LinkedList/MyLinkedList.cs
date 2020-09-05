namespace leetcode.learn.LinkedList
{
    public class MyLinkedList
    {
        Node _head;

        /** Initialize your data structure here. */
        public MyLinkedList()
        {

        }

        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {
            if (_head == null)
                return -1;
            var tempIndex = 0;
            var temNode = _head;
            while (temNode != null)
            {
                if (tempIndex == index)
                    return temNode.Value;
                temNode = temNode.NextNode;
                tempIndex++;
            }

            return -1;
        }

        /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {
            var tempNode = new Node(val);
            tempNode.NextNode = _head;
            _head = tempNode;
        }

        /** Append a node of value val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            var lastNode = _head;
            while (lastNode.NextNode != null)
            {
                lastNode = lastNode.NextNode;
            }
            lastNode.NextNode = new Node(val);
        }

        /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val)
        {
            if (index < 0)
                return;

            if (index == 0)
            {
                var newHead = new Node(val);
                newHead.NextNode = _head;
                _head = newHead;
                return;
            }

            var currentNode = _head;
            Node previousNode = null;

            var i = 0;
            while (currentNode != null & i < index)
            {
                previousNode = currentNode;
                currentNode = currentNode.NextNode;
                i++;
            }

            if (i == index)
            {
                var newNode = new Node(val);
                newNode.NextNode = currentNode;
                previousNode.NextNode = newNode;
            }
        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            if (index < 0)
                return;

            if (index == 0)
            {
                _head = _head.NextNode;
                return;
            }

            var currentNode = _head;
            Node previousNode = null;

            var i = 0;
            while (currentNode != null & i < index)
            {
                previousNode = currentNode;
                currentNode = currentNode.NextNode;
                i++;
            }

            if (i == index)
                previousNode.NextNode = currentNode?.NextNode;
        }


        private Node GetNodeByIndex(int index)
        {


            return null;
        }
    }

    /**
     * Your MyLinkedList object will be instantiated and called as such:
     * MyLinkedList obj = new MyLinkedList();
     * int param_1 = obj.Get(index);
     * obj.AddAtHead(val);
     * obj.AddAtTail(val);
     * obj.AddAtIndex(index,val);
     * obj.DeleteAtIndex(index);
     */
}
