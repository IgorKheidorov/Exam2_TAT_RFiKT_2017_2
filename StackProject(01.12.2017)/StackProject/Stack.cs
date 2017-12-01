using System;

namespace StackProject
{
    /// <summary>
    /// Collection where elements are stored according to the principle Last In First Out
    /// </summary>
    /// <typeparam name="T">type of stored values</typeparam>
    public class Stack<T>
    {
        /// <summary>
        /// Stores the current anount of elements in the stack
        /// </summary>
        public int Count
        {
            get; private set;
        }
        /// <summary>
        /// Head of the stack
        /// </summary>
        private StackNode<T> HeadNode
        {
            get;set;
        }
        /// <summary>
        /// return value, which HeadNode contain
        /// </summary>
        public T Head
        {
            get
            {
                return HeadNode.value;
            }
        }
        /// <summary>
        /// Add new element to stack, this new element becomes the head of the stack
        /// and increments elements count;
        /// </summary>
        /// <param name="value">value we want to add</param>
        public void Push(T value)
        {
            StackNode<T> newHead = new StackNode<T>();
            newHead.value = value;
            if ( HeadNode == null )
            {
                HeadNode = newHead;
            }
            else
            {
                newHead.previousElement = HeadNode;
                HeadNode = newHead;
            }
            Count++;
        }
        /// <summary>
        /// Returnes value in the head stack without changing the stack's state.
        /// Throws InvalidOperationException if the stack is empty
        /// </summary>
        /// <returns>the value which stored in the head</returns>
        public T Peek()
        {
            if ( HeadNode != null )
            {
                return HeadNode.value;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
        /// <summary>
        /// Returnes value in the head stack and replace head to the previous.
        /// Throws InvalidOperationException if the stack is empty
        /// </summary>
        /// <returns>the value which stored in the head</returns>
        public T Pop()
        {
            T returnedValue;
            if ( HeadNode != null )
            {
                returnedValue = HeadNode.value;
                HeadNode = HeadNode.previousElement;
                Count--;
            }
            else
            {
                throw new InvalidOperationException();
            }
            return returnedValue;
        }
        /// <summary>
        /// Clear all links and set elements count to 0
        /// </summary>
        public void Clear()
        {
            if ( HeadNode == null )
            {
                return;
            }
            StackNode<T> removedElement = HeadNode;
            StackNode<T> previousElement;
            while ( removedElement != null )
            {
                previousElement = removedElement.previousElement;
                removedElement = null;
                removedElement = previousElement;
            }
            Count = 0;
        }
        /// <summary>
        /// The method determines is the specified value contains in the stack
        /// </summary>
        /// <param name="value">the value that we are looking for in the stack</param>
        /// <returns>is the specified value contains in the stack</returns>
        public bool Contains(T value)
        {
            bool isContains = false;
            if ( HeadNode != null )
            {
                StackNode<T> currentElement = HeadNode;
                StackNode<T> previousElement;
                while ( currentElement != null )
                {
                    if ( currentElement.value.Equals(value) )
                    {
                        isContains = true;
                        break;
                    }
                    previousElement = currentElement.previousElement;
                    currentElement = previousElement;
                }
            }
            return isContains;
        }

    }
}
