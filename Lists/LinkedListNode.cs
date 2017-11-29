using System;

namespace LinkedLists
{
  /// <summary>
  /// Implementation of the element of linked list collection.
  /// </summary>
  public class LinkedListNode
  {
    public int Value { get; set; }
    public LinkedListNode Next { get; set; }
    public LinkedListNode Previous { get; set; }
    public LinkedListNode(int value)
    {
      Value = value;
    }
    public LinkedListNode()
    {

    }
  }
}
