using System;

namespace List
{
  /// <summary>
  /// This class represetns Doubly Connected List
  /// </summary>
  /// <typeparam name="T">Type of data saved in the list. It can be any type</typeparam>
  public class DoublyConnectedList<T>
  {
    DoublyConnectedListNode<T> firstNode;
    DoublyConnectedListNode<T> lastNode;
    DoublyConnectedListNode<T> currentNode;
    public int Count { get; set; }

    /// <summary>
    /// Initiates current node
    /// </summary>
    public void InitCurrentNode()
    {
      currentNode = firstNode;
    }

    /// <summary>
    /// Gets next node
    /// </summary>
    /// <param name="node">Current node</param>
    /// <returns>Next Node</returns>
    public DoublyConnectedListNode<T> GetNext(DoublyConnectedListNode<T> node)
    {
      return node.NextElement;
    }

    /// <summary>
    /// Gets previous node
    /// </summary>
    /// <param name="node">Current node</param>
    /// <returns>Previous Node</returns>
    public DoublyConnectedListNode<T> GetPrevious(DoublyConnectedListNode<T> node)
    {
      return node.PreviousElement;
    }

    /// <summary>
    /// Add a new node to the talil of list
    /// </summary>
    /// <param name="newElement">Element to add</param>
    public void Add(T newElement)
    {
      DoublyConnectedListNode<T> newNode = new DoublyConnectedListNode<T>(newElement);
      if (firstNode == null)
      {
        firstNode = newNode;
      }
      else
      {
        newNode.PreviousElement = lastNode;
        lastNode.NextElement = newNode;
      }
      lastNode = newNode;
      Count++;
    }

    /// <summary>
    /// Removes first node equal to element to remove
    /// </summary>
    /// <param name="element">Element to remove</param>
    public void Remove(T element)
    {
      InitCurrentNode();
      while (currentNode != null)
      {
        if (currentNode.Element.Equals(element))
        {
          if (currentNode.PreviousElement != null)
          {

            currentNode.PreviousElement.NextElement = currentNode.NextElement;
            currentNode.NextElement.PreviousElement = currentNode.PreviousElement;
            if (currentNode.NextElement == null)
            {
              lastNode = currentNode.PreviousElement;
            }
          }
          else
          {
            firstNode = firstNode.NextElement;
            if (firstNode == null)
            {
              lastNode = null;
            }
          }
          Count--;
          break;
        }
        currentNode = currentNode.NextElement;
      }
    }

    /// <summary>
    /// Deletes all nodes from list
    /// </summary>
    public void Clear()
    {
      firstNode = null;
      lastNode = null;
      Count = 0;
    }

    /// <summary>
    /// Checks if list contains a node
    /// </summary>
    /// <param name="element">Node to search for</param>
    /// <returns>True if list contains such node and False if it doesn't</returns>
    public bool Contains(T element)
    {
      InitCurrentNode();
      while (currentNode != null)
      {
        if (currentNode.Element.Equals(element))
        {
          return true;
        }
        currentNode = currentNode.NextElement;
      }
      return false;
    }

    /// <summary>
    /// Adds a node in the head of list
    /// </summary>
    /// <param name="element">Node to add</param>
    public void AppendFirst(T element)
    {
      DoublyConnectedListNode<T> newNode = new DoublyConnectedListNode<T>(element);
      newNode.NextElement = firstNode;
      firstNode = newNode;
      Count++;
    }
  }
}
