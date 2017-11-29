using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Project
{
  /// <summary>
  /// 
  /// </summary>
  /// <typeparam name="T"></typeparam>
  public class CustomList<T> : IEnumerable<T>
  {
    public Node<T> First { get; set; }
    public Node<T> Last { get; set; }
    private int count;

    public int Count { get; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="data"></param>
    public void Add(T data)
    {
      Node<T> node = new Node<T>(data);

      if (First == null)
      {
        First = node;
      }
      else
      {
        Last.Next = node;
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
      Node<T> node = new Node<T>(data);
      node.Next = First;
      First = node;
      if (count == 0)
        Last = First;
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
      else
      {
        Node<T> node = new Node<T>(item);
        Node<T> current = GetElement(index);
        Node<T> previous = GetElement(index - 1);

        node.Next = current;
        previous.Next = node;

        count++;
      }



    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="data"></param>
    /// <returns></returns>
    public bool Remove(T data)
    {
      Node<T> current = First;
      Node<T> previous = null;

      while (current != null)
      {
        if (current.Value.Equals(data))
        {
          ChangeNodes(previous, current);
          count--;
          return true;
        }

        previous = current;
        current = current.Next;
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

      var current = GetElement(index);
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
      Node<T> current = First;
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
      Node<T> current = First;
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
    /// <returns></returns>
    public IEnumerator<T> GetEnumerator()
    {
      return (IEnumerator<T>)((IEnumerable)this).GetEnumerator();
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
    /// <param name="index"></param>
    /// <returns></returns>
    private Node<T> GetElement(int index)
    {
      Node<T> current = First;

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
    /// <param name="previous"></param>
    /// <param name="current"></param>
    private void ChangeNodes(Node<T> previous, Node<T> current)
    {
      if (previous != null)
      {
        previous.Next = current.Next;

        if (current.Next == null)
          Last = previous;
      }
      else
      {
        First = First.Next;
        if (First == null)
          Last = null;
      }
    }
  }
}
