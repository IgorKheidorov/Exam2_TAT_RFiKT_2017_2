using System;

namespace LinkedLists
{
    /// <summary>
    /// Node for the double linked list.
    /// Contains reference to the next element and previous element.
    /// </summary>
    class DoubleNode
    {
        public int Data { get; set; }
        public DoubleNode(int data)
        {
            Data = data;
        }
        public DoubleNode Next { get; set; }
        public DoubleNode Previous { get; set; }
    }
}
