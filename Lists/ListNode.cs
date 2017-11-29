using System;

namespace LinkedLists
{
  /// <summary>
  /// Implementation of the element of list collection.
  /// </summary>
  public class ListNode
  {
    public int Value { get; set; }
    public ListNode Next { get; set; }
    public ListNode()
    {

    }
    public ListNode(int value)
    {
      Value = value;
    }

  }
}
