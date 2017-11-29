namespace TwoTypesOfList
{
  /// <summary>
  /// Class node for a doubly linked list.
  /// </summary>
  public class NodeDoublyLinkedList
  {
    public NodeDoublyLinkedList Previous { get; set; }
    public int Value { get; set; }   
    public NodeDoublyLinkedList Next { get; set; }
    public NodeDoublyLinkedList(int value)
    {
      Value = value;
    }
  }
}
