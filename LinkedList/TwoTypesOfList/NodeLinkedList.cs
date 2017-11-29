namespace TwoTypesOfList
{
  /// <summary>
  /// Class node for a linked list.
  /// </summary>
  public class NodeLinkedList
  {
    public int Value { get; private set; }
    public NodeLinkedList Next { get; set; }
    public NodeLinkedList(int value)
    {
      Next = null;
      Value = value;
    }
  }
}
