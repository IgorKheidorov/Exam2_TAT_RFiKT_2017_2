namespace Task4_29_11_17
{
    /// <summary>
    /// Realise node to double linked list
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class NodeToDoubleLinkedList<T>
    {
        public T Value { get; private set; }
        public NodeToDoubleLinkedList<T> Next { get; set; }
        public NodeToDoubleLinkedList<T> Previous { get; set; }

        /// <summary>
        /// Initialize node with sourse value
        /// </summary>
        /// <param name="value">
        /// soure value
        /// </param>
        public NodeToDoubleLinkedList(T value)
        {
            this.Value = value;
            Next = null;
            Previous = null;
        }
    }
}