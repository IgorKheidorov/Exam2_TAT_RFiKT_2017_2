namespace LinkedListProject
{
  public class DoubleLinkedList<T> : IList<T>
  {
    public DoubleNode<T> Head { get; private set; }
    public DoubleNode<T> Tail { get; private set; }
    public int Count { get; private set; }

    /// <summary>
    /// This is default constructor for DoubleLinkedList.
    /// </summary>
    public DoubleLinkedList()
    {
      Head = null;
      Tail = null;
    }

    /// <summary>
    /// This is constructor for DoubleLinkedList with parameters.
    /// </summary>
    /// <param name="value"> any value </param>
    public DoubleLinkedList(T value)
    {
      DoubleNode<T> node = new DoubleNode<T>(value);
      Head = node;
      Tail = node;
      Count++;
    }

    /// <summary>
    /// This method adds element to list.
    /// </summary>
    /// <param name="value"> any value</param>
    public void Add(T value)
    {
      DoubleNode<T> node = new DoubleNode<T>(value);
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
      Count++;
    }

    /// <summary>
    /// This methode gets value by index.
    /// </summary>
    /// <param name="index"> index of element </param>
    /// <returns> value from list by index</returns>
    public T GetValue(int index)
    {
      DoubleNode<T> current = Head;
      int counter = 0;
      while (current != null)
      {
        if (counter == index)
        {
          return current.Value;
        }
        current = current.Next;
        counter++;
      }
      return current.Value;
    }

    /// <summary>
    /// This method adds element to head.
    /// </summary>
    /// <param name="value"> any value </param>
    public void AddFirst(T value)
    {
      DoubleNode<T> node = new DoubleNode<T>(value);
      DoubleNode<T> temp = Head;
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
    /// This method removes element from list.
    /// </summary>
    /// <param name="value"> any value </param>
    /// <returns> true if removed, false if it's not </returns>
    public bool Remove(T value)
    {
      DoubleNode<T> current = Head;
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
        Count--;
        return true;
      }
      return false;
    }

    /// <summary>
    /// This method clears list.
    /// </summary>
    public void Clear()
    {
      Head = null;
      Tail = null;
      Count = 0;
    }

    /// <summary>
    /// This method checks if list contains value.
    /// </summary>
    /// <param name="value"> any value </param>
    /// <returns> true if list contains value, false if it is not </returns>
    public bool Contains(T value)
    {
      DoubleNode<T> current = Head;
      while (current != null)
      {
        if (current.Value.Equals(value))
        {
          return true;
        }
        current = current.Next;
      }
      return false;
    }
  }
}