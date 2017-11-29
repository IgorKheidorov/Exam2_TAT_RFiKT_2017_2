namespace LinkedListProject
{
  /// <summary>
  /// This is class for LinkedList
  /// </summary>
  /// <typeparam name="T"> any type of element </typeparam>
  public class LinkedList<T> : IList<T>
  {
    public Node<T> Head { get; private set; }
    public Node<T> Tail { get; private set; }
    public int Count { get; private set; }
    private Node<T> Current { get; set; }

    /// <summary>
    /// This is default constructor for LinkedList.
    /// </summary>
    public LinkedList()
    {
      Head = null;
      Tail = null;
      Count++;
    }

    /// <summary>
    /// This is constructor for LinkedList with parameters.
    /// </summary>
    /// <param name="value"> any object </param>
    public LinkedList(T value)
    {
      Node<T> node = new Node<T>(value);
      Head = node;
      Tail = node;
      Count++;
    }

    /// <summary>
    /// This method initialize current element by head.
    /// </summary>
    public void InitCurrentByHead()
    {
      Current = Head;
    }

    /// <summary>
    /// This method gets next element. If it is last element, method will return current.
    /// </summary>
    /// <returns> next element </returns>
    public Node<T> GetNext()
    {
      if (Current.Next == null)
      {
        return Current;
      }
      Current = Current.Next;
      return Current;
    }

    /// <summary>
    /// This method add element to list.
    /// </summary>
    /// <param name="value"> any problem </param>
    public void Add(T value)
    {
      Node<T> node = new Node<T>(value);
      if (Head == null)
      {
        Head = node;
        Tail = node;
      }
      else
      {
        Tail.Next = node;
        Tail = node;
      }
      Count++;
    }

    /// <summary>
    /// This method clear list.
    /// </summary>
    public void Clear()
    {
      Head = null;
      Tail = null;
      Current = null;
      Count = 0;
    }

    /// <summary>
    /// This is method that checks contains of value in list.
    /// </summary>
    /// <param name="value"> any value </param>
    /// <returns> true if contains </returns>
    public bool Contains(T value)
    {
      Node<T> node = Head;
      while (node != null)
      {
        if (node.Value.Equals(value))
          return true;
        node = node.Next;
      }
      return false;
    }
    
    /// <summary>
    /// This method adds value to the head of list.
    /// </summary>
    /// <param name="value"> any value </param>
    public void AddFirst(T value)
    {
      Node<T> node = new Node<T>(value)
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
    /// This method remove element drom list.
    /// </summary>
    /// <param name="value"> any value </param>
    /// <returns> true if removed, false if it's not </returns>
    public bool Remove(T value)
    {
      if (Head == null)
      {
        return false;
      }
      Node<T> node = Head;
      if (node.Value.Equals(value))
      {
        Head = node.Next;
        Count--;
        return true;
      }
      while (node != Tail)
      {
        if (node.Next.Value.Equals(value))
        {
          node.Next = node.Next.Next;
          Count--;
          return true;
        }
        node = node.Next;
      }
      return false;
    }
  }
}