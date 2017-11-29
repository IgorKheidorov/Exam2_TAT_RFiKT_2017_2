using System;
using System.Collections;
using System.Collections.Generic;


namespace TaskAboutLists
{
    /// <summary>
    /// Representation of unidirectional list.
    /// </summary>
    public class UnidirectionalList<Type> : IEnumerable
    {
        /// <summary>
        /// Representation  element of list.
        /// </summary>
        /// <typeparam name="Type">type of value of element.</typeparam>
        class Element<Type>
        {
            public Type value { get; }
            public Element<Type> next { get; set; }

            /// <summary>
            /// Default constructor.
            /// </summary>
            public Element()
            {
                next = this;
            }

            /// <summary>
            /// Constructor with parametrs.
            /// </summary>
            /// <param name="value">Value of element.</param>
            public Element(Type value)
            {
                next = this;               
                this.value = value;
            }

        }

        private Element<Type> head;
        private Element<Type> tail;
        public int count { get; set; }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public UnidirectionalList()
        {
            head = null;
            head.next = null;
            count = 0;
        }

        /// <summary>
        /// Adds element to list.
        /// </summary>
        /// <param name="value">Value of elelemnt to add.</param>
        public void Add(Type value)
        {
            Element<Type> newElement = new Element<Type>(value);

            if (head == null)
            {
                head = newElement;              
            }
            else
            {
                tail.next = newElement;            
            }
            tail = newElement;
            count++;
        }

        /// <summary>
        /// Checks if list contains element.
        /// </summary>
        /// <param name="value">Value of element.</param>
        /// <returns>True if list contains element;false otherwise.</returns>
        public bool Contains(Type value)
        {
            Element<Type> current = head;
            while (current != null)
            {
                if (current.value.Equals(value))
                {
                    return true;
                }
                current = current.next;
            }
            return false;
        }

        /// <summary>
        /// Removes element in list.
        /// </summary>
        /// <param name="value">Value of element to remove.</param>
        public void Remove(Type value)
        {
            Element<Type> current = head.next;
            Element<Type> previous = null;
            while (current != null)
            {
                if (current.value.Equals(value))
                {
                    if (previous != null)
                    {
                        previous.next = current.next;
                        if (current.next == null)
                        {
                            tail = previous;
                        }
                    }
                    else
                    {
                        head = head.next;
                        if (head == null)
                        {
                            tail = null;
                        }
                    }
                    count--;
                }
                previous = current;
                current = current.next;
            }
        }

        /// <summary>
        /// Clears list.
        /// </summary>
        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        /// <summary>
        /// Returns enumerator of elelemnts in list.
        /// </summary>
        /// <returns>Returns enumerator of elelemnts in list.</returns>
        public IEnumerator GetEnumerator()
        {
            return CreateEnumerator();
        }

        /// <summary>
        /// Returns next element in list.
        /// </summary>
        /// <returns>Returns next element in list.</returns>
        IEnumerator<Type> CreateEnumerator()
        {
            Element<Type> current = head;
            while (current != null)
            {
                yield return current.value;
                current = current.next;
            }
        }
    }
}
