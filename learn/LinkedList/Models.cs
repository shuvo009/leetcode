using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.learn.LinkedList
{
    public class Node
    {
        public Node(int value)
        {
            Value = value;
        }

        public int Value { get; private set; }
        public Node NextNode { get; set; }
    }
}
