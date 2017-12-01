namespace MyStack
{
  /// <summary>
  /// Node for list initialization
  /// </summary>
  /// <typeparam name="T">For type of objects</typeparam>
  public class Node<T>
  {
    public T Value { get; set; }
    public Node<T> Next { get; set; }

    /// <summary>
    /// Constructor without parameters
    /// </summary>
    public Node()
    { }

    /// <summary>
    /// Trivial constructor with parameter
    /// </summary>
    /// <param name="data">Value of parameter</param>
    public Node(T data)
    {
      Value = data;
    }
  }
}
