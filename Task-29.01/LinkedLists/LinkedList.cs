using System;

namespace LinkedLists
{
    /// <summary>
    /// Linked list with head and tail node.
    /// </summary>
    public class LinkedList
    {
        Node head;
        Node tail;
        Node current;
        public int Count { get; set; }
        public LinkedList()
        {
            head = null;
            tail = null;
        }
        /// <summary>
        /// Gets head.
        /// </summary>
        /// <returns>Head value.</returns>
        public Node GetHead()
        {
            return head;
        }
        /// <summary>
        /// Gets  tail.
        /// </summary>
        /// <returns>Tail value.</returns>
        public Node GetTail()
        {
            return tail;
        }
        /// <summary>
        /// Gets current elements.
        /// </summary>
        /// <returns>Current value.</returns>
        public Node GetCurrent()
        {
            current = head;
            return current;
        }
        /// <summary>
        /// Get element of the list.
        /// If there isn't next node return current node.
        /// </summary>
        /// <returns>Next element</returns>
        public Node GetNext()
        {
            Node cur = this.GetCurrent();
            if (cur != null)
            {
                if (cur.Next != null)
                {
                    cur = cur.Next;
                }
            }
            return cur;
        }
        /// <summary>
        /// Inserts a new node to the list.
        /// </summary>
        /// <param name="value">Inserted value.</param>
        public void Add(int value)
        {
            Node newNode = new Node(value);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                tail.Next = newNode;
            }
            tail = newNode;
            Count++;
        }
        /// <summary>
        /// Inserts value to the first position.
        /// </summary>
        /// <param name="value">Inserted value</param>
        public void AddFirst(int value)
        {
            Node newNode = new Node(value);
            newNode.Next = head;
            head = newNode;
            if (Count == 0)
            {
                tail = head;
            }
            Count++;
        }
        /// <summary>
        /// Removes element from the list;
        /// </summary>
        /// <param name="value">Removed value</param>
        /// <returns>True - node is removed.
        /// False - isn't removed</returns>
        public bool Remove(int value)
        {
            Node temp = head;
            Node previous = null;
            while (temp != null)
            {
                if (temp.Data.Equals(value))
                {
                    if (previous != null)
                    {
                        previous.Next = temp.Next;
                        if (temp.Next == null)
                        {
                            tail = previous;
                        }
                    }
                    else
                    {
                        head = temp.Next;
                        if (temp == null)
                        {
                            tail = null;
                        }
                    }
                    Count--;
                    return true;
                }
                previous = temp;
                temp = temp.Next;
            }
            return false;
        }
        /// <summary>
        /// Inserts element value to the list to the position index.
        /// </summary>
        /// <param name="index">Position of the insert.</param>
        /// <param name="value">Inserted value.</param>
        public void Insert(int index, int value)
        {
            Node newNode = new Node(value);
            Node temp = head;
            Node previous = null;
            while (temp != null)
            {
                if (Count.Equals(index))
                {
                    if (previous != null)
                    {
                        temp.Next = newNode;
                        newNode.Next = temp.Next;
                        if (temp.Next == null)
                        {
                            tail = temp;
                        }
                    }
                    else
                    {
                        head = temp.Next;
                        if (temp == null)
                        {
                            tail = null;
                        }
                    }
                    Count++;
                }
                previous = temp;
                temp = temp.Next;
            }
        }
        /// <summary>
        /// Clears elements of the list.
        /// </summary>
        public void Clear()
        {
            head = null;
            tail = null;
            Count = 0;
        }
        /// <summary>
        /// Checks if element contains in the list.
        /// </summary>
        /// <returns>True - contains
        /// False - doesn't conatin.</returns>
        public bool Contains(int value)
        {
            Node temp = head;
            while (temp != null)
            {
                if (temp.Data.Equals(value))
                {
                    return true;
                }  
                temp = temp.Next;
            }
            return false;
        }
    }
}
