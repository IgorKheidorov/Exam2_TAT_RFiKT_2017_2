namespace ListProject
{
    public class List<T> : IList<T>
    {
        ListNode<T> vertex;
        ListNode<T> end;
        ListNode<T> iterator;

        public int Count
        {
            get; private set;
        }
        /// <summary>
        /// stores head of the list
        /// </summary>
        public ListNode<T> First
        {
            get
            {
                return vertex;
            }
        }
        /// <summary>
        /// stores end of the list
        /// </summary>
        public ListNode<T> Last
        {
            get
            {
                return end;
            }
        }

        public List()
        {
            Count = 0;
        }
        /// <summary>
        /// add new value to the tail
        /// </summary>
        /// <param name="value"></param>
        public void Add(T value)
        {
            ListNode<T> node = new ListNode<T>();
            node.value = value;
            if ( vertex == null )
            {
                vertex = node;
                end = vertex;
            }
            else
            {
                end.next = node;
                end = end.next;
            }
            Count++;
        }


        public void Clear()
        {
            Count = 0;
            vertex = null;
            end = null;
            iterator = null;
        }
        /// <summary>
        /// try to remove value from the list
        /// </summary>
        /// <param name="value"></param>
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
            }
            else
            {
                ListNode<T> preIterator = vertex;
                ListNode<T> iterator = preIterator.next;
                while (preIterator.next != null )
                {
                    if ( iterator.value.Equals(value) )
                    {
                        if ( iterator == end)
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

        public T GetNext()
        {
         if ( iterator == null )
            {
                iterator = vertex;
                return iterator.value;
            }
            iterator = iterator.next;
            return iterator.value;              
        }
    }
}
