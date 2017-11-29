namespace Task4_29_11_17
{
    /// <summary>
    /// Realised linked list
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkedList<T>
    {
        private NodeToLinkedList<T> head;
        private NodeToLinkedList<T> tail;

        /// <summary>
        /// Counted number of elements in list
        /// </summary>
        /// <returns>
        /// number of elements
        /// </returns>
        public int Count()
        {
            var element = head;
            int count = 0;
            while (element != null)
            {
                element = element.Next;
                count++;
            }

            return count;
        }

        /// <summary>
        /// Get position of first of elements with the same value. 
        /// If there aren't elements with sourse value, return -1.
        /// </summary>
        /// <param name="value">
        /// finding value
        /// </param>
        /// <returns>
        /// index, or -1, if there aren't elements with param value
        /// </returns>
        public int GetPositionOfElement(T value)
        {
            var element = head;
            int count = 0;
            while (element != null)
            {
                element = element.Next;
                count++;

                if (element.Value.Equals(value))
                {
                    break;
                }
                else if (element.Next == null)
                {
                    count = -1;
                    break;
                }
            }

            return count;
        }

        /// <summary>
        /// Get head
        /// </summary>
        /// <returns>
        /// head
        /// </returns>
        public NodeToLinkedList<T> GetHead()
        {
            return head;
        }

        /// <summary>
        /// Get tail
        /// </summary>
        /// <returns>
        /// tail
        /// </returns>
        public NodeToLinkedList<T> GetTail()
        {
            return tail;
        }


        /// <summary>
        /// Add element to the end of list
        /// </summary>
        /// <param name="value">
        /// element value
        /// </param>
        public void Add(T value)
        {
            NodeToLinkedList<T> node = new NodeToLinkedList<T>(value);
            if (head == null)
            {
                head = node;
                tail = head;
            }
            else
            {
                tail.Next = node;
                tail = node;
            }
        }

        /// <summary>
        /// Remove first element with the same value from list.
        /// If there aren't elements with param value, return false.
        /// </summary>
        /// <param name="value">
        /// value of element, which need to delete
        /// </param>
        /// <returns>
        /// true, if remove. False, if doesn't remove.
        /// </returns>
        public bool Remove(T value)
        {
            NodeToLinkedList<T> previous = null;
            NodeToLinkedList<T> current = head;
            bool removed = false;

            while (!removed)
            {
                if (!current.Value.Equals(value))
                {
                    previous = current;
                    current = current.Next;

                    if (current == null)
                    {
                        break;
                    }
                }
                else if (previous != null)
                {
                    previous.Next = current.Next;
                    removed = true;
                }
                else
                {
                    head = head.Next;
                    removed = true;
                }
            }

            return removed;
        }
    }
}