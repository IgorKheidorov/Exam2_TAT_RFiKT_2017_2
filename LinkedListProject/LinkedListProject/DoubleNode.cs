namespace LinkedListProject
{
  /// <summary>
  /// This is node for double linked list.
  /// </summary>
  /// <typeparam name="T"> any type of value </typeparam>
  public class DoubleNode<T>
  {
    public T Value { get; set; }
    public DoubleNode<T> Previous { get; set; }
    public DoubleNode<T> Next { get; set; }

    /// <summary>
    /// This is constructor for DoubleNode() class.
    /// </summary>
    /// <param name="value"> any value </param>
    public DoubleNode(T value)
    {
      Value = value;
    }
  }
}