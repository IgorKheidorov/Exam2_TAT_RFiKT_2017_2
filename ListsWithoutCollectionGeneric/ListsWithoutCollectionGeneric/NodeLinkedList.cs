using System;

namespace ListsWithoutCollectionGeneric
{
  /// <summary>
  /// The realization of LinkedList's node.
  /// </summary>
  public class NodeLinkedList
  {
    public int Value { get; private set; }
    public NodeLinkedList Next { get; set; }

    /// <summary>
    /// This metod is used for initialization the node of LinkedList.
    /// </summary>
    /// <param name="value">
    /// The parameter which is a value of the node. 
    /// </param>
    public NodeLinkedList(int value)
    {
      Value = value;
    }
  }
}
