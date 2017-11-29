namespace ListProject
{
    public class LinkedList<T> : IList<T>
    {
        LinkedListNode<T> vertex;
        LinkedListNode<T> end;
        LinkedListNode<T> iterator;

        public int Count
        {
            get; private set;
        }

        /// <summary>
        /// return list head
        /// </summary>
        public LinkedListNode<T> First
        {
            get
            {
                return vertex;
            }
        }

        /// <summary>
        /// return last element
        /// </summary>
        public LinkedListNode<T> Last
        {
            get
            {
                return end;
            }
        }

        public LinkedList()
        {
            Count = 0;
        }

        /// <summary>
        /// add value to end of list
        /// </summary>
        /// <param name="value"></param>
        public void Add(T value)
        {
            LinkedListNode<T> node = new LinkedListNode<T>();
            node.value = value;
            if (vertex == null)
            {
                vertex = node;
                end = vertex;
            }
            else
            {
                node.previous = end;
                end.next = node;
                end = end.next;
            }
            Count++;
        }

        /// <summary>
        /// remove all elements and set 0 to Count property
        /// </summary>
        public void Clear()
        {
            Count = 0;
            vertex = null;
            end = null;
            iterator = null;
        }

        /// <summary>
        /// method remove value if such element exist
        /// </summary>
        /// <param name="value">value to remove</param>
        public void Remove(T value)
        {
            if (vertex == null) return;
            if (Count == 1 && vertex.value.Equals(value))
            {
                Count--;
                vertex = null;
                end = null;
            }
            else if (vertex.value.Equals(value))
            {
                Count--;
                vertex = vertex.next;
                vertex.previous = null;
            }
            else
            {
                LinkedListNode<T> preIterator = vertex;
                LinkedListNode<T> iterator = preIterator.next;
                while (preIterator.next != null)
                {
                    if (iterator.value.Equals(value))
                    {
                        if (iterator == end)
                        {
                            end = preIterator;
                            Count--;
                            return;
                        }
                        preIterator.next = iterator.next;
                        Count--;
                        return;
                    }
                    preIterator = iterator;
                    iterator = iterator.next;
                }
            }
        }

        /// <summary>
        /// iterator from end to head
        /// </summary>
        /// <returns></returns>
        public LinkedListNode<T> GetPrevious()
        {

            if (vertex == null)
            {
                return null;
            }
            else if (iterator == null && vertex != null)
            {
                iterator = end;
            }
            else iterator = iterator.previous;
            return iterator;
        }

        /// <summary>
        /// iterator from head to end
        /// </summary>
        /// <returns></returns>
        public T GetNext()
        {

            if (vertex == null)
            {
                return null;
            }
            else if (iterator == null && vertex != null)
            {
                iterator = vertex;
            }
            else iterator = iterator.next;
            return iterator.value;
        }
    }
}
