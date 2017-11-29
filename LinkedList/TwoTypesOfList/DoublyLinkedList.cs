namespace TwoTypesOfList
{
  /// <summary>
  /// Implementation of a doubly linked list.
  /// </summary>
  public class DoublyLinkedList
  {
    int count;
    public NodeDoublyLinkedList Head { get; set; }
    public NodeDoublyLinkedList Tail { get; set; }
    public int Count { get; set; }

    /// <summary>
    /// Adding an item to the end of the list.
    /// </summary>
    /// <param name="value">your value</param>    
    public void AddValueToDoublyLinkedList(int value)
    {
      NodeDoublyLinkedList node = new NodeDoublyLinkedList(value);

      if (Head == null)
      {
        Head = node;
      }        
      else
      {
        Tail.Next = node;
        node.Previous = Tail;
      }
      Tail = node;
      count++;
    }

    /// <summary>
    /// Adding an item to the top of the list.
    /// </summary>
    /// <param name="value">your value</param>
    public void AddFirst(int value)
    {
      NodeDoublyLinkedList node = new NodeDoublyLinkedList(value);
      NodeDoublyLinkedList temp = Head;
      node.Next = temp;
      Head = node;
      if (count == 0)
      {
        Tail = Head;
      }
      else
      {
        temp.Previous = node;
      }       
      count++;
    }

    /// <summary>
    /// Remove from list.
    /// </summary>
    /// <param name="value">your value</param>
    /// <returns></returns>
    public bool Remove(int value)
    {
      NodeDoublyLinkedList current = Head;     
      while (current != null)
      {
        if (current.Value.Equals(value))
        {
          break;
        }
        current = current.Next;
      }
      if (current != null)
      {       
        if (current.Next != null)
        {
          current.Next.Previous = current.Previous;
        }
        else
        {         
          Tail = current.Previous;
        }
       
        if (current.Previous != null)
        {
          current.Previous.Next = current.Next;
        }
        else
        {         
          Head = current.Next;
        }
        count--;
        return true;
      }
      return false;
    }
  }
}
