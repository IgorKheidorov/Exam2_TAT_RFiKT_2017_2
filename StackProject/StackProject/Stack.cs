using System;

namespace StackProject
{
  /// <summary>
  /// This is class for stack.
  /// </summary>
  /// <typeparam name="T"> Any type of value </typeparam>
  public class Stack<T>
  {
    public Node<T> Head { get; private set; }
    public int Count { get; private set; }

    /// <summary>
    /// This class checks if stack is empty.
    /// </summary>
    /// <returns> True if stack is empty and false if it is not </returns>
    public bool IsEmpty()
    {
      return Count == 0;
    }

    /// <summary>
    /// This method adds element to stack.
    /// </summary>
    /// <param name="element"> Any element </param>
    public void Push(T element)
    {
      Node<T> node = new Node<T>(element);
      node.Next = Head;
      Head = node;
      Count++;
    }

    /// <summary>
    /// This method gets and delete first element from stack.
    /// If stack is empty method will throw an exception.
    /// </summary>
    /// <returns> Head element </returns>
    public T Pop()
    {
      if (IsEmpty())
      {
        throw new InvalidOperationException();
      }
      Node<T> node = Head;
      Head = Head.Next; 
      Count--;
      return node.Value;
    }

    /// <summary>
    /// This method takes head element from stack.
    /// If stack is empty method will throw an exception.
    /// </summary>
    /// <returns> Head element </returns>
    public T Peek()
    {
      if (IsEmpty())
      {
        throw new InvalidOperationException();
      }
      return Head.Value;
    }

    /// <summary>
    /// This method clears stack.
    /// </summary>
    public void Clear()
    {
      Node<T> node;
      Node<T> nextNode;
      while(Count != 0)
      {
        node = Head;
        nextNode = Head.Next;
        node = null;
        Head = nextNode;
        Count--;
      }
    }
  }
}