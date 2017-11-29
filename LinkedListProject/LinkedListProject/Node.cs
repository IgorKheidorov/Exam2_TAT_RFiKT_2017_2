namespace LinkedListProject
{
  /// <summary>
  /// This is node for LinkedList.
  /// </summary>
  /// <typeparam name="T"></typeparam>
  public class Node<T>
  {
    public T Value { get; set; }
    public Node<T> Next { get; set; }

    /// <summary>
    /// This is constructor for Node class.
    /// </summary>
    /// <param name="value"> any value </param>
    public Node(T value)
    {
      Value = value;
    }
  }
}