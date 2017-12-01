
namespace StackImplementation
{
  /// <summary>
  /// Implementation of elements of stack.
  /// </summary>
  /// <typeparam name="T">
  /// Any type of value.
  /// </typeparam>
  public class Node<T>
  {
    public T Value { get; set; }
    public Node<T> Next { get; set; }
    public Node(T value)
    {
      Value = value;
    }

  }
}
