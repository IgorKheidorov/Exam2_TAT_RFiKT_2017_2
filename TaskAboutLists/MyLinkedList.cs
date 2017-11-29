using System;
using System.Collections;
using System.Collections.Generic;


namespace TaskAboutLists
{
    /// <summary>
    /// Represantation of LinkedList.
    /// </summary>
    /// <typeparam name="Type"></typeparam>
    public class MyLinkedList<Type> : IEnumerable<Type>
    {
        /// <summary>
        /// Representation of element of linkedlist.
        /// </summary>
        /// <typeparam name="Type">Type of stored elements.</typeparam>
        public class Element<Type>
        {
            public Type value { get;}
            public Element<Type> next { get; set; }
            public Element<Type> previous { get; set;}

            /// <summary>
            /// Default constructor.
            /// </summary>
            public Element()
            {
                next = this;
                previous = this;
                
            }

            /// <summary>
            /// Constructor with parametrs.
            /// </summary>
            /// <param name="value">Value of elelment to create.</param>
            public Element(Type value)
            {
                next = this;
                previous = this;
                this.value = value;
            }
        }

        private Element<Type> head;
        public int count { get; set; }

        /// <summary>
        /// Creates an insance of MyLInkedList.
        /// </summary>
        public MyLinkedList()
        {
            head = new Element<Type>();
            head.next = head;
            head.previous = head;
            count = 0;
        }

        /// <summary>
        /// Adds element to list.
        /// </summary>
        /// <param name="value">Value of elelemnt to add.</param>
        public void Add(Type value)
        {
            Element<Type> newElement = new Element<Type>(value);           
            if (count > 0)
            {
                newElement.previous = head.previous;
                newElement.next = head;
                head.previous = newElement;                
            }
            else
            {
                newElement.previous = head.previous;
                newElement.next = head;
                head.previous = newElement;
                head.next = newElement;               
            }
            count++;           
        }

        /// <summary>
        /// Removes first elelement.
        /// </summary>
        public void RemoveFirst()
        {
            this.Remove(head.next);
        }

        /// <summary>
        /// Removes last element.
        /// </summary>
        public void RemoveLast()
        {
            this.Remove(head.previous);
        }

        private void Remove(Element<Type> element)
        {
            if (head.next == head)
            {
                throw new ArgumentException();
            }

            element.previous.next = element.next;
            element.next.previous = element.previous;
            element.next = null;
            element.previous = null;
            count--;
        }

        /// <summary>
        /// Removes element.
        /// </summary>
        /// <param name="value">Value of element to remove.</param>
        public void Remove(Type value)
        {
            this.Remove(this.GetElement(value));
        }
        /// <summary>
        /// Returns element.
        /// </summary>
        /// <param name="value">Value of element to return.</param>
        /// <returns>Return element.</returns>
        public Element<Type> GetElement(Type value)
        {
            Element<Type> element = head.next;
            while (element != head)
            {
                if (element.value.Equals(value))
                {
                    break;
                }
                element = element.next;
            }
            return element;
        }

        /// <summary>
        /// Returns first element of list.
        /// </summary>
        /// <returns>First element of list.</returns>
        public Type GetFirst()
        {
            return head.next.value;
        }
        /// <summary>
        /// Checks if list contains element.
        /// </summary>
        /// <param name="value">Value of element.</param>
        /// <returns>True if list contains element;false otherwise.</returns>
        public bool Contains(Type value)
        {
            Element<Type> element = head.next;
            while (element != head)
            {
                if (element.value.Equals(value))
                {
                    return true;
                }
                element = element.next;
            }
            return false;
        }

        /// <summary>
        /// Clears list.
        /// </summary>
        public void Clear()
        {
            head.next = head;
            head.previous = head;
            count = 0;
        }

        /// <summary>
        /// Returns next element in list.
        /// </summary>
        /// <returns>Returns next element in list.</returns>
        IEnumerator<Type> IEnumerable<Type>.GetEnumerator()
        {
            Element<Type> current = head.next;
            while (current != head)
            {              
                yield return current.value;
                current = current.next;

            }
        }

        /// <summary>
        /// Returns enumerator of elelemnts in list.
        /// </summary>
        /// <returns>Returns enumerator of elelemnts in list.</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
    }
}
