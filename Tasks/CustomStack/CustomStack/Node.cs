
namespace CustomStack
{
  /// <summary>
  /// describes the entity
  /// used to create collections
  /// with a link of elements to the next
  /// </summary>
  public class Node<T>
  {
    public Node(T value)
    {
      Value = value;
    }
    public T Value { get; set; }
    public Node<T> Next { get; set; }
  }
}
