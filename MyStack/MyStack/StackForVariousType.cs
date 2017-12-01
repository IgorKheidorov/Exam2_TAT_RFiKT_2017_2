using System;

namespace MyStack
{
  /// <summary>
  /// The implementation of stack
  /// </summary>
  /// <typeparam name="T">Type of values</typeparam>
  public class StackOnList<T>
  {
    public Node<T> Head { get; set; }
    public int Count { get; private set; }

    /// <summary>
    /// It adds an element to the top of the stack
    /// </summary>
    /// <param name="value">Value of element which you want to add</param>
    public void Push(T value)
    {
      Node<T> node = new Node<T>(value)
      {
        Next = Head
      };
      Head = node;
      Count++;
    }

    /// <summary>
    /// An element is returned from the top of the stack and also it deleted. 
    /// Also if the stack is empty, an Exception will throw.
    /// </summary>
    /// <returns>The value of the element</returns>
    public T Pop()
    {
      if(Count == 0)
      {
        throw new Exception("Your stack is empty.");
      }
      Node<T> newElement = Head;
      Head = Head.Next;
      Count--;
      return newElement.Value;
    }

    /// <summary>
    ///It returns an element from the top of the stack, but will not deleted
    ///Also if the stack is empty, an Exception will throw.
    /// </summary>
    /// <returns>Value of the element</returns>
    public T Peek()
    {
      if (Count == 0)
      {
        throw new Exception("Your stack is empty.");
      }
      return Head.Value;
    }

    /// <summary>
    /// For cleaning all nodes int the stack 
    /// </summary>
    public void  Clear()
    {
      Node<T> currentNode = new Node<T>();
      Node<T> nextNode = new Node<T>();
      while(Count != 0)
      {
        currentNode = Head;
        nextNode = currentNode.Next;
        currentNode = null;
        Head = nextNode;
        Count--;
      }
    }
  }
}
