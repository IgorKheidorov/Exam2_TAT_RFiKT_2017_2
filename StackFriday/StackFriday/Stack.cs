using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackFriday
{
    class Stack<T>
    {
        private Node<T> top;
        public int count { get; private set; }

        /// <summary>
        /// Removes all objects from the Stack.
        /// </summary>
        public void Clear()
        {
            if (top == null)
            {
                return;
            }
            Node<T> next = top.nextNode;
            while (next != null)
            {
                top = null;
                top = next;
                next = next.nextNode;
            }
        }

        /// <summary>
        /// Returns the object at the top of the Stack without removing it.
        /// </summary>
        /// <returns> Returns value on the top. </returns>
        public T Peek()
        {
            return top.value;
        }

        /// <summary>
        /// Returns number of objects in stack.
        /// </summary>
        /// <returns> Returns number of objects in stack. </returns>
        public int Count()
        {
            return count;
        }

        /// <summary>
        /// Removes object at the top of the Stack.
        /// </summary>
        /// <returns> Value of removing object. </returns>
        public T Pop()
        {
            if (!IsEmpty())
            {
                count--;
                Node<T> toRemove = top;
                top = top.nextNode;
                return toRemove.value;
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        /// <summary>
        /// Add new element to stack.
        /// </summary>
        /// <param name="value"> New value of node to insert in stack. </param>
        public void Push(T value)
        {
            Node<T> newNode = new Node<T>();
            newNode.value = value;
            newNode.nextNode = top;
            top = newNode;
            count++;
        }

        /// <summary>
        /// Returns true if stack empty.
        /// </summary>
        /// <returns> Returns true if stack empty. </returns>
        public bool IsEmpty()
        {
            return top == null ? true : false;
        }

    }
}
