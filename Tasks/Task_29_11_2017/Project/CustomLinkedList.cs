using System;

namespace Project
{
  /// <summary>
  /// Custom class describes doubly-linked lists
  /// </summary>
  /// <typeparam name="T"></typeparam>
  public class CustomLinkedList<T>
  {
    private DoublyNode<T> head;
    private DoublyNode<T> tail;
    private DoublyNode<T> currentNode;

    public int Count { get; private set; }

    /// <summary>
    /// Add item in list
    /// </summary>
    /// <param name="item"></param>
    public void Add(T item)
    {
      DoublyNode<T> node = new DoublyNode<T>(item);

      if (head == null)
        head = node;
      else
      {
        tail.Next = node;
        node.Previous = tail;
      }
      tail = node;
      Count++;
    }

    /// <summary>
    /// Add item in the first position of the list
    /// </summary>
    /// <param name="item"></param>
    public void AppendFirst(T item)
    {
      DoublyNode<T> node = new DoublyNode<T>(item);
      DoublyNode<T> temp = head;
      node.Next = temp;
      head = node;
      if (Count == 0)
        tail = head;
      else
        temp.Previous = node;
      Count++;
    }

    /// <summary>
    /// Insert item in the some position of the list
    /// Throws exception if index is invalid
    /// </summary>
    /// <param name="index">Position</param>
    /// <param name="item">Data</param>
    public void Insert(int index, T item)
    {
      if (index >= Count)
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
    /// Remove item in list
    /// </summary>
    /// <param name="item">Data</param>
    /// <returns>True if succesfull removing, false otherwise</returns>
    public bool Remove(T item)
    {
      DoublyNode<T> current = head;

      while (current != null)
      {
        if (current.Value.Equals(item))
        {
          break;
        }
        current = current.Next;
      }
      if (current != null)
      {
        ChangePreviousNextInDoublyNodes(current);
        Count--;
        return true;
      }
      return false;
    }

    /// <summary>
    /// Remove item from some position in list
    /// Throws exception if index is invalid
    /// </summary>
    /// <param name="index">position</param>
    public void RemoveAt(int index)
    {
      if (index >= Count)
        throw new ArgumentOutOfRangeException();
      DoublyNode<T> current = GetElement(index);
      Remove(current.Value);
    }

    /// <summary>
    /// Check if the list is empty
    /// </summary>
    /// <returns>True if empty, false otherwise</returns>
    public bool IsEmpty()
    {
      return Count == 0;
    }

    /// <summary>
    /// Clear list
    /// </summary>
    public void Clear()
    {
      head = null;
      tail = null;
      Count = 0;
    }

    /// <summary>
    /// Check if list contains some data
    /// </summary>
    /// <param name="data">checked data</param>
    /// <returns>True if contains, else otherwise</returns>
    public bool Contains(T data)
    {
      DoublyNode<T> current = head;
      while (current != null)
      {
        if (current.Value.Equals(data))
          return true;
        current = current.Next;
      }
      return false;
    }

    /// <summary>
    /// Get index of item in list
    /// </summary>
    /// <param name="item">item</param>
    /// <returns>Index if list contains item, -1 otherwise</returns>
    public int IndexOf(T item)
    {
      DoublyNode<T> current = head;
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
    /// Get element in list by index
    /// </summary>
    /// <param name="index"></param>
    /// <returns>Node element</returns>
    private DoublyNode<T> GetElement(int index)
    {
      DoublyNode<T> current = head;
      int currentIndex = 0;

      while (currentIndex != index)
      {
        current = current.Next;
        currentIndex++;
      }
      return current;
    }

    /// <summary>
    /// Help method to method Remove
    /// </summary>
    /// <param name="current">DoublyNode</param>
    private void ChangePreviousNextInDoublyNodes(DoublyNode<T> current)
    {
      if (current.Next != null)
      {
        current.Next.Previous = current.Previous;
      }
      else
      {
        tail = current.Previous;
      }

      if (current.Previous != null)
      {
        current.Previous.Next = current.Next;
      }
      else
      {
        head = current.Next;
      }
    }
  }
}
