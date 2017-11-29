using System;

namespace LinkedLists
{
    /// <summary>
    /// Node for the linked list. Contains reference to the next element.
    /// </summary>
    public class Node 
    {
        public int Data { get; set; }
        public Node(int data)
        {
            Data = data;
        }
        public Node Next { get; set; }
    }
}
