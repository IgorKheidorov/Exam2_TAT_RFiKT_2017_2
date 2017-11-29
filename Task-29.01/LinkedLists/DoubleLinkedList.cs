using System;
using System.Collections.Generic;

namespace LinkedLists
{
    /// <summary>
    /// Double linked list with head and tail nodes, that contain
    /// references to the next node and previous node.
    /// </summary>
    public class DoubleLinkedList
    {
        DoubleNode head;
        DoubleNode tail;
        public int Count { get; set; }
        /// <summary>
        /// Inserts a new node to the list.
        /// </summary>
        /// <param name="value">Inserted value.</param>
        public void Add(int value)
        {
            DoubleNode newNode = new DoubleNode(value);
            if(head == null)
            {
                head = newNode;
            }
            else
            {
                tail.Next = newNode;
                newNode.Previous = tail;
            }
            tail = newNode;
            Count++;
        }
        /// <summary>
        /// Inserts element to the list to the first.
        /// </summary>
        /// <param name="value">Inserted value.</param>
        public void AddFirst(int value)
        {
            DoubleNode newNode = new DoubleNode(value);
            DoubleNode temp = head;
            newNode.Next = temp;
            head = newNode;
            if (Count == 0)
            {
                tail = head;
            }
            else
            {
                temp.Previous = newNode;
            }
            Count++;
        }
        /// <summary>
        /// Removes element from the list.
        /// </summary>
        /// <param name="value">Removed value</param>
        /// <returns>True - removing is sucsessful.
        /// False - is not.</returns>
        public bool Remove(int value)
        {
            DoubleNode temp = head;
            DoubleNode previous = null;
            while(temp != null)
            {
                if (temp.Data.Equals(value))
                {
                    if (previous != null)
                    {
                        previous.Next = temp.Next;
                        temp.Next.Previous = previous;
                    }
                    else 
                    {
                        head = temp.Next;
                    }
                    if (temp.Next != null)
                    {
                        temp.Next.Previous = temp.Previous;
                        temp.Previous = temp.Next;
                    }
                    else
                    {
                        tail = temp.Previous;
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
        ///  Clears elements of the list.
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
            DoubleNode temp = head;
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
