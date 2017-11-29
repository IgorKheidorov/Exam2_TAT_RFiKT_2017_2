using System;

namespace ListsWithoutCollectionGeneric
{
  public class DoublyLinkedList
  {
    private int count;
    public NodeDoublyLinkedList Head { get; set; }
    public NodeDoublyLinkedList Tail { get; set; }
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
    NodeDoublyLinkedList Current { get; set; } 
    public void AddToEnd(int value)
    {
      NodeDoublyLinkedList node = new NodeDoublyLinkedList(value);
      if (null == Head)
      {
        Head = node;
      }
      else
      {
        Tail.Next = node;
        node.Previous = Tail;
      }
      Tail = node;
      Count++;
    }

    /// <summary>
    /// Add new node to the start of list.
    /// </summary>
    /// <param name="value"></param>
    public void AddToStart(int value)
    {
      NodeDoublyLinkedList node = new NodeDoublyLinkedList(value);
      NodeDoublyLinkedList temp = Head;
      node.Next = temp;
      Head = node;
      if (Count == 0)
      {
        Tail = Head;
      }
      else
      {
        temp.Previous = node;
      }
      Count++;
    }

    /// <summary>
    /// Remove if current element not first and not last.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public bool Remove(int value)
    {
      Current = Head;
      while (Current != null)
      {
        if (Current.Value.Equals(value))
        {
          break;
        }
        Current = Current.Next;
      }
      if (Current != null)
      {
        if (Current.Next != null)
        {
          Current.Next.Previous = Current.Previous;
        }
        else
        {
          Tail = Current.Previous;
        }
        if (Current.Previous != null)
        {
          Current.Previous.Next = Current.Next;
        }
        else
        {
          Head = Current.Next;
        }
        Count--;
        return true;
      }
      return false;
    }

    /// <summary>
    /// Get value of privious element.
    /// </summary>
    /// <returns></returns>
    public NodeDoublyLinkedList GetPrivious()
    {
      if (Current != null && Current.Previous != null)
      {
        return Current = Current.Previous;
      }
      else
      {
        return Current;
      }
    }

    /// <summary>
    /// Get first element in the list.
    /// </summary>
    /// <returns></returns>
    public NodeDoublyLinkedList GetHead()
    {
      return Current = Head;
    }

    /// <summary>
    /// Get last element in the list.
    /// </summary>
    /// <returns></returns>
    public NodeDoublyLinkedList GetTail()
    {
      return Current = Tail;
    }

    /// <summary>
    /// Get next value of node.
    /// </summary>
    /// <returns></returns>
    public NodeDoublyLinkedList GetNext()
    {
      if (Current != null && Current.Next != null)
      {
        return Current = Current.Next;
      }
      else
      {
        throw new Exception("Current element is null.");
      }
    }

    /// <summarry>
    /// For clearing all LinkedList.
    /// </summary>
    public void Clear()
    {
      Head = Tail = null;
      Count = 0;
    }
  }
}
