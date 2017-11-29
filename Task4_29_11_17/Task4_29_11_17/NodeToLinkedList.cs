namespace Task4_29_11_17
{
    /// <summary>
    /// Realise node to linked list
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class NodeToLinkedList<T>
    {
        public T Value { get; private set; }
        public NodeToLinkedList<T> Next { get; set; }

        /// <summary>
        /// Initialize node with sourse value
        /// </summary>
        /// <param name="value">
        /// soure value
        /// </param>
        public NodeToLinkedList(T value)
        {
            this.Value = value;
            Next = null;
        }
    }
}