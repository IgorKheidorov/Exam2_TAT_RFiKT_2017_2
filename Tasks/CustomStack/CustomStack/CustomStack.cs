using System;

namespace CustomStack
{
  /// <summary>
  /// Custom stack realized on Nodes
  /// </summary>
  public class CustomStack<T>
  {
    private Node<T> head;
    public int Count { get; private set; }

    /// <summary>
    /// Add new item in head position from stack
    /// </summary>
    /// <param name="item">added item</param>
    public void Push(T item)
    {
      Node<T> node = new Node<T>(item);
      node.Next = head;
      head = node;
      Count++;
    }

    /// <summary>
    /// Get value of head element, and remove it from stack
    /// </summary>
    /// <returns>Deleted value</returns>
    public T Pop()
    {
      if (IsEmpty())
      {
        throw new InvalidOperationException();
      }
      T value = head.Value;
      head = head.Next;
      Count--;
      return value;
    }

    /// <summary>
    /// Get value of stacks head
    /// </summary>
    /// <returns>Current head value</returns>
    public T Peek()
    {
      if (IsEmpty())
      {
        throw new InvalidOperationException();
      }
      return head.Value;
    }

    /// <summary>
    /// Clear stack
    /// </summary>
    public void Clear()
    {
      while (!IsEmpty())
      {
        Pop();
      }
    }

    /// <summary>
    /// Check stack on empty
    /// </summary>
    /// <returns>True if Count == 0, false otherwise</returns>
    public bool IsEmpty()
    {
      return Count == 0;
    }
  }
}
