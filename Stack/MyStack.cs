using System;


namespace StackImplementation
{
  /// <summary>
  /// Implementation of stack collection.
  /// </summary>
  /// <typeparam name="T">
  /// Any type of value.
  /// </typeparam>
  public class MyStack<T>
  {
    Node<T> head;
    public int Count { get; private set; }
    /// <summary>
    /// Adds the element to end of stack.
    /// </summary>
    /// <param name="element">
    /// Element to add.
    /// </param>
    public void Push(T element)
    {
      Node<T> node = new Node<T>(element);
      node.Next = head;
      head = node;
      Count++;
    }
    /// <summary>
    /// Deletes last element from stack and returns is.
    /// </summary>
    /// <returns>
    /// Last element of stack.
    /// </returns>
    public T Pop()
    {
      if (Count == 0)
      {
        throw new Exception("Stack is empty");
      }
      Node<T> temp = head;
      head = head.Next;
      Count--;
      return temp.Value;
    }
    /// <summary>
    /// Returns last element of stack without deleting it.
    /// </summary>
    /// <returns>
    /// Last element of stack.
    /// </returns>
    public T Peek()
    {
      if (Count == 0)
      {
        throw new Exception("Stack is empty");
      }
      return head.Value;
    }
    /// <summary>
    /// Clears the stack.
    /// </summary>
    public void Clear()
    {
      Node<T> currentElement;
      Node<T> nextElement;
      while (Count != 0)
      {
        currentElement = head;
        nextElement = head.Next;
        currentElement = null;
        head = nextElement;
        Count--;
      }
    }
  }
}