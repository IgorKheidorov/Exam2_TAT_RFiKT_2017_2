using System;
using System.Collections;
using System.Collections.Generic;

namespace Project
{
  /// <summary>
  /// Custom class describes linked list
  /// </summary>
  /// <typeparam name="T"></typeparam>
  public class CustomList<T> : IEnumerable<T>, IEnumerator<T>
  {
    //public Node<T> First { private get; set; }
    //public Node<T> Last { private get; set; }
    private Node<T> head;
    private Node<T> tail;
    private static Node<T> currentNode;

    public int Count { get; private set; }

    public CustomList()
    {
      currentNode = head;
    }
    /// <summary>
    /// Add item in list
    /// </summary>
    /// <param name="item">Data</param>
    public void Add(T item)
    {
      Node<T> node = new Node<T>(item);

      if (head == null)
      {
        head = node;
      }
      else
      {
        tail.Next = node;
      }
      tail = node;

      Count++;
    }

    /// <summary>
    /// Add item in the first position of the list
    /// </summary>
    /// <param name="item">Data</param>
    public void AppendFirst(T item)
    {
      Node<T> node = new Node<T>(item);
      node.Next = head;
      head = node;
      if (Count == 0)
        tail = head;
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
      if (index >= Count || index < 0)
        throw new ArgumentOutOfRangeException();

      if (index == 0)
        AppendFirst(item);
      else if (index == Count - 1)
      {
        Add(item);
      }
      else
      {
        Node<T> node = new Node<T>(item);
        Node<T> current = GetElement(index);
        Node<T> previous = GetElement(index - 1);

        node.Next = current;
        previous.Next = node;

        Count++;
      }
    }

    /// <summary>
    /// Remove item in list
    /// </summary>
    /// <param name="item">Data</param>
    /// <returns>True if succesfull removing, false otherwise</returns>
    public bool Remove(T item)
    {
      Node<T> current = head;
      Node<T> previous = null;

      while (current != null)
      {
        if (current.Value.Equals(item))
        {
          ChangeNodes(previous, current);
          Count--;
          return true;
        }

        previous = current;
        current = current.Next;
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
      if (index >= Count || index < 0)
        throw new ArgumentOutOfRangeException();

      var current = GetElement(index);
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
      Node<T> current = head;
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
      Node<T> current = head;
      int index = 0;
      while (current != null)
      {
        if (current.Value.Equals(item))
          return index;
        current = current.Next;
        index++;
      }
      return -1;
    }

    /// <summary>
    /// Get value of next elem in list
    /// </summary>
    /// <returns></returns>
    public T GetCurrentValue()
    {
      T value = currentNode.Value;
      if (currentNode.Next == null)
      {
        currentNode = head;
      }
      else
      {
        currentNode = currentNode.Next;
      }
      return value;
    }

    /// <summary>
    /// Get element in list by index
    /// </summary>
    /// <param name="index"></param>
    /// <returns>Node element</returns>
    private Node<T> GetElement(int index)
    {
      Node<T> current = head;

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
    /// <param name="previous">DoublyNode</param>
    /// <param name="current">DoublyNode</param>
    private void ChangeNodes(Node<T> previous, Node<T> current)
    {
      if (previous != null)
      {
        previous.Next = current.Next;

        if (current.Next == null)
          tail = previous;
      }
      else
      {
        head = head.Next;
        if (head == null)
          tail = null;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public IEnumerator<T> GetEnumerator()
    {
      throw new NotImplementedException();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    IEnumerator IEnumerable.GetEnumerator()
    {
      return GetEnumerator();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public bool MoveNext()
    {
      if (currentNode.Next == null)
      {
        Reset();
        return false;
      }

      currentNode = currentNode.Next;
      return true;
    }

    /// <summary>
    /// 
    /// </summary>
    public void Reset()
    {
      currentNode = head;
    }

    /// <summary>
    /// 
    /// </summary>
    public T Current { get { return currentNode.Value; } }

    /// <summary>
    /// 
    /// </summary>
    object IEnumerator.Current
    {
      get { return Current; }
    }

    /// <summary>
    /// 
    /// </summary>
    public void Dispose()
    {
      throw new NotImplementedException();
    }
  }
}
