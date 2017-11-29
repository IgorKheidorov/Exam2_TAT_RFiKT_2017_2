namespace TwoTypesOfList
{
  /// <summary>
  /// Implementation of a linked list.
  /// </summary>
  public class LinkedList
  {
    int count;
    public NodeLinkedList Head { get; set; }
    public NodeLinkedList Tail { get; set; }
    public int Count { get; set; }    
    public LinkedList()
    {
      Head = null;
      Tail = null;
    }

    /// <summary>
    /// Adding an item to the end of the list.
    /// </summary>
    /// <param name="value">your value</param>
    public void AddValueToLinkedList(int value)
    {
      NodeLinkedList newTail = new NodeLinkedList(value);
      newTail.Next = null;

      if (null == Head)
      {
        Head = Tail = newTail;
        count++;
      }
      else
      {
        Tail.Next = newTail;
        Tail = newTail;
        count++;
      }     
    }

    /// <summary>
    /// Adding an item to the top of the list.
    /// </summary>
    /// <param name="value">your value</param>
    public void AppendFirst(int value)
    {
      NodeLinkedList node = new NodeLinkedList(value);
      node.Next = Head;
      Head = node;
      if (count == 0)
      {
        Tail = Head;
        count++;
      }
    }

    /// <summary>
    /// Remove from list.
    /// </summary>
    /// <param name="value">your value</param>
    public void Remove(int value)
    {
      NodeLinkedList node = Head;
      while (node != null)
      {
        if (node.Next.Value == value)
        {
          node.Next = node.Next.Next;
          break;
        }
        node = node.Next;
      }
    }
  }
}