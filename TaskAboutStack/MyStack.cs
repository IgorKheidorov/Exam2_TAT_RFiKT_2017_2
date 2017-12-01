using System;

namespace TaskAboutStack
{
  /// <summary>
  /// Representation of stack.
  /// </summary>
  /// <typeparam name="Type">Type of elements in the stack.</typeparam>
  public class MyStack<Type>
  {
    private Element<Type> head;
    private Element<Type> tail;
    public int count { get; private set; }

    /// <summary>
    /// Default constructor.
    /// </summary>
    public MyStack()
    {
      head = null;
      tail = null;
      count = 0;
    }

    /// <summary>
    /// Returns the element at the top of the stack without removing it.
    /// </summary>
    /// <returns>element at the top of the stack</returns>
    public Type Peek()
    {
      if (IsEmpty())
      {
        throw new InvalidOperationException("Stack is empty.");
      }
      return tail.value;
    }

    /// <summary>
    /// Inserts an element at the top of the stack.
    /// </summary>
    /// <param name="value">Value of the element.</param>
    public void Push(Type value)
    {
      Element<Type> newElement = new Element<Type>(value);
      if (head == null)
      {
        head = newElement;
        tail = newElement;
      }
      else
      {
        tail.next = newElement;
        tail = newElement;
      }
      count++;
    }

    /// <summary>
    /// Returns the element at the top of the stack with removing it.
    /// </summary>
    /// <returns>Element at the top of the stack</returns>
    public Type Pop()
    {
      if (IsEmpty())
      {
        throw new InvalidOperationException("Stack is empty.");
      }

      Element<Type> topOfOtheStack = tail;
      Element<Type> current = head;
      while (current != null)
      {
        if (current.next == tail)
        {
          current.next = null;
          tail = current;
        }
        current = current.next;
      }
      count--;
      return topOfOtheStack.value;
    }

    /// <summary>
    /// Clears the stack.
    /// </summary>
    public void Clear()
    {
      if (IsEmpty())
      {
        return;
      }
      Element<Type> current = tail;
      while (count > 0)
      {
        this.Pop();
      }
    }

    /// <summary>
    /// Checks if the stack is empty.
    /// </summary>
    /// <returns>True is the stack is empty;otherwise false.</returns>
    public bool IsEmpty()
    {
      return count == 0;
    }
  }
}

