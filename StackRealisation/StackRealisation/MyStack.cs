using System;
using System.Collections.Generic;

namespace StackRealisation
{
    /// <summary>
    /// Class that realizes data structure Stack.
    /// </summary>
    /// <typeparam name="T">Specifies the type of elements in the stack</typeparam>
    public class MyStack<T>
    {
        public Node<T> Head { get; private set; }
        public int Count { get; private set; }
        public MyStack()
        {
            Head = null;
            Count = 0;
        }
        /// <summary>
        /// Defines if the stack is empty.
        /// </summary>
        public bool IsEmpty
        {
            get { return Count == 0; }
        }
        /// <summary>
        /// Inserts an object at the top of the Stack
        /// </summary>
        /// <param name="item">Inserted value.</param>
        public void Push(T item)
        {
            Node<T> newNode = new Node<T>(item);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head = newNode;
            }
            Count++;
        }
        /// <summary>
        /// Returns the object at the top of the MyStack without removing it.
        /// </summary>
        /// <returns>Top of the stack.
        /// Generates exception if the stack is empty.</returns>
        public T Peek()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException();
            }
            return Head.Data;
        }
        /// <summary>
        /// Removes and returns the object at the top of the MyStack. 
        /// </summary>
        /// <returns>The object at the top of the Stack.
        /// Generates InvalidOperationException if stack is empty.</returns>
        public T Pop()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException();
            }
            T deletedItem = Head.Data;
            Head = Head.Next;
            Count--;
            return deletedItem;
        }
        /// <summary>
        /// Removes all objects from the MyStack.
        /// Generates InvalidOperationException if stack is empty.
        /// </summary>
        public void Clear()
        {
            while (!IsEmpty)
            {
                Pop();
            }
        }
    }
}
