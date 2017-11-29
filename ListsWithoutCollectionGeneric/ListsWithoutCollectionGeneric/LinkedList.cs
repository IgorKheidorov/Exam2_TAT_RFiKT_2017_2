
namespace ListsWithoutCollectionGeneric
{
  /// <summary>
  /// The initialization of List.
  /// </summary>
  public class LinkedList
  {
    public NodeLinkedList Head { get; set; }
    public NodeLinkedList Tail { get; set; }

    private int count;
    public int Count
    {
      get
      {
        return count;
      }
      set
      {
        count = value;
      }
    }

    /// <summary>
    /// This metod is used for addition some value to the end of list.
    /// </summary>
    /// <param name="value">
    /// The parameter to be added.
    /// </param>
    public void AddToEnd(int value)
    {
      NodeLinkedList newTail = new NodeLinkedList(value);

      if (null == Head)
      {
        Head = Tail = newTail;
        Count++;
      }
      else
      {
        Tail.Next = newTail;
        Tail = newTail;
        Count++;
      }
    }

    /// <summary>
    /// Add the node to the start of ours list.
    /// </summary>
    /// <param name="value"></param>
    public void AddToStart(int value)
    {
      NodeLinkedList node = new NodeLinkedList(value)
      {
        Next = Head
      };

      Head = node;
      if (Count == 0)
      {
        Tail = Head;
      }
      Count++;
    }

    /// <summary>
    /// This class is used for removing value,we pass from EntryPoint class.
    /// </summary>
    /// <param name="value">
    /// The parameter which is removed
    /// </param>
    public bool RemoveFromLinkedList(int value)
    {
      NodeLinkedList node = Head;
      while (node != Tail)
      {
        if (node.Next.Value == value)
        {
          node.Next = node.Next.Next;
          Count--;
          return true;
        }
        node = node.Next;
      }
      return false;
    }

    /// <summary>
    /// For clearing of all LinkedList.
    /// </summary>
    public void ClearTheLinkedList()
    {
      Head = Tail = null;
      Count = 0;
    }
  }
}
