using System;
using System.Collections.Generic;

namespace StackRealisation
{
    /// <summary>
    /// Node for the Stack. Contains reference to the next element.
    /// </summary>
    public class Node<T>
    {
        public T Data { get; set; }
        public Node(T data)
        {
            Data = data;
        }
        public Node<T> Next { get; set; }
    }
}
