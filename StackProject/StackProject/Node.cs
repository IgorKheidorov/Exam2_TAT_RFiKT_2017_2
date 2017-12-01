namespace StackProject
{
  /// <summary>
  /// This is node for Stack.
  /// </summary>
  /// <typeparam name="T"> Any type of value </typeparam>
  public class Node<T>
  {
    public T Value { get; set; }
    public Node<T> Next { get; set; }

    /// <summary>
    /// This is constructor for Node class.
    /// </summary>
    /// <param name="value"> Any value </param>
    public Node(T value)
    {
      Value = value;
    }
  }
}