using System;

namespace Test_3.Task_5
{
  /// <summary>
  /// This class realizes stack.
  /// </summary>
  public class MyStack<Type>
  {
    private Node<Type> firstElement;
    private Node<Type> lastElement;
    private Node<Type> current = new Node<Type>();
    private int count = 0;

    /// <summary>
    /// This method adds element in the front. 
    /// </summary>
    /// <param name="value">Element that will be added.</param>
    public void Push(Type value)
    {
      Node<Type> node = new Node<Type>(value);

      if (firstElement == null)
      {
        firstElement = node;
        lastElement = node;
      }
      else
      {
        node.Next = lastElement;
        firstElement = node;
      }

      count++;
    }

    /// <summary>
    /// This method deletes top from stack and returns it. 
    /// </summary>
    /// <returns>Top.</returns>
    public Type Pop()
    {
      IsEmpty();
      current = firstElement;
      firstElement = firstElement.Next;
      count--;
      return current.Value;
    }

    /// <summary>
    /// This method returns top. 
    /// </summary>
    /// <returns>Top.</returns>
    public Type Peek()
    {
      IsEmpty();
      return firstElement.Value;
    }

    private void IsEmpty()
    {
      if (count == 0)
      {
        throw new InvalidOperationException();
      }
    }

    /// <summary>
    /// This method deletes all elements from stack.
    /// </summary>
    public void Clear()
    {
      current = firstElement;
      do
      {
        current = current.Next;
      }
      while (current.Next != null);

      count = 0;
    }

    public int Count { get { return count; } }
  }
}
