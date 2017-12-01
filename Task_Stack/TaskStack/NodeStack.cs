using System;

namespace TaskStack
{
  /// <summary>
  /// Implementing the stack with its standard methods.
  /// </summary>
  public class NodeStack<T>
  {
    Node<T> head;
    public int Count { get; private set; }
   
    /// <summary>
    /// The method adds an element to the top of the stack.
    /// </summary>
    /// <param name="item">the item we want to add to the stack</param>
    public void Push(T item)
    {      
      Node<T> node = new Node<T>(item);
      node.Next = head;
      head = node;
      Count++;
    }

    /// <summary>
    /// The method removes and returns an element from the top of the stack. 
    /// If the stack is empty, an InvalidOperationException is thrown.
    /// </summary>
    /// <returns>element value</returns>
    public T Pop()
    {     
      if (Count == 0)
      {
        throw new InvalidOperationException("Stack is empty");
      }        
      Node<T> temp = head;
      head = head.Next; 
      Count--;
      return temp.Value;
    }

    /// <summary>
    /// The method returns an element from the top of the stack without deleting it.
    /// </summary>
    /// <returns>element value</returns>
    public T Peek()
    {
      if (Count == 0)
      {
        throw new InvalidOperationException("Stack is empty");
      }       
      return head.Value;
    }

    /// <summary>
    /// The method clear the stack.
    /// </summary>
    public void Clear()
    {
      Node<T> currentNode = new Node<T>();
      Node<T> nextNode = new Node<T>();
      while (Count != 0)
      {
        currentNode = head;
        nextNode = currentNode.Next;
        currentNode = null;
        head = nextNode;
        Count--;         
      }
    }    
  }
}