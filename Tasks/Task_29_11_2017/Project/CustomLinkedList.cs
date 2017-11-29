using System;

namespace Project
{
  /// <summary>
  /// 
  /// </summary>
  /// <typeparam name="T"></typeparam>
  public class CustomLinkedList<T>
  {
    public DoublyNode<T> First { get; set; }
    public DoublyNode<T> Last { get; set; }

    private int count;
    public int Count { get; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="data"></param>
    public void Add(T data)
    {
      DoublyNode<T> node = new DoublyNode<T>(data);

      if (First == null)
        First = node;
      else
      {
        Last.Next = node;
        node.Previous = Last;
      }
      Last = node;
      count++;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="data"></param>
    public void AppendFirst(T data)
    {
      DoublyNode<T> node = new DoublyNode<T>(data);
      DoublyNode<T> temp = First;
      node.Next = temp;
      First = node;
      if (count == 0)
        Last = First;
      else
        temp.Previous = node;
      count++;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="index"></param>
    /// <param name="item"></param>
    public void Insert(int index, T item)
    {
      if (index >= count)
        throw new ArgumentOutOfRangeException();

      if (index == 0)
        AppendFirst(item);

      DoublyNode<T> node = new DoublyNode<T>(item);
      DoublyNode<T> current = GetElement(index);

      node.Next = current;
      node.Previous = current.Previous;

      current.Previous = node;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="data"></param>
    /// <returns></returns>
    public bool Remove(T data)
    {
      DoublyNode<T> current = First;

      while (current != null)
      {
        if (current.Value.Equals(data))
        {
          break;
        }
        current = current.Next;
      }
      if (current != null)
      {
        ChangePreviousNextInDoublyNodes(current);
        count--;
        return true;
      }
      return false;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="index"></param>
    public void RemoveAt(int index)
    {
      if (index >= count)
        throw new ArgumentOutOfRangeException();
      DoublyNode<T> current = GetElement(index);
      Remove(current.Value);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public bool IsEmpty()
    {
      return count == 0;
    }

    /// <summary>
    /// 
    /// </summary>
    public void Clear()
    {
      First = null;
      Last = null;
      count = 0;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="data"></param>
    /// <returns></returns>
    public bool Contains(T data)
    {
      DoublyNode<T> current = First;
      while (current != null)
      {
        if (current.Value.Equals(data))
          return true;
        current = current.Next;
      }
      return false;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="item"></param>
    /// <returns></returns>
    public int IndexOf(T item)
    {
      DoublyNode<T> current = First;
      int index = 0;
      while (current != null)
      {
        index++;
        if (current.Value.Equals(item))
          return index;
        current = current.Next;
      }
      return -1;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="index"></param>
    /// <returns></returns>
    private DoublyNode<T> GetElement(int index)
    {
      DoublyNode<T> current = First;
      int currentIndex = 0;

      while (currentIndex != index)
      {
        current = current.Next;
        currentIndex++;
      }
      return current;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="current"></param>
    private void ChangePreviousNextInDoublyNodes(DoublyNode<T> current)
    {
      if (current.Next != null)
      {
        current.Next.Previous = current.Previous;
      }
      else
      {
        Last = current.Previous;
      }

      if (current.Previous != null)
      {
        current.Previous.Next = current.Next;
      }
      else
      {
        First = current.Next;
      }
    }
  }
}
