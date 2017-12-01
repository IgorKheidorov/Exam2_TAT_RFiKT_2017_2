namespace StackProject
{
    /// <summary>
    /// Is a node for a stack
    /// </summary>
    /// <typeparam name="T">type of the stored value</typeparam>
    class StackNode<T>
    {
        public T value;
        public StackNode<T> previousElement;
    }
}
