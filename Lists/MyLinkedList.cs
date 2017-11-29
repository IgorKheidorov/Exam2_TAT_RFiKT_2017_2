using System;

namespace LinkedLists
{
  /// <summary>
  /// Implementation of int linked list.
  /// </summary>
  public class MyLinkedList
  {
    LinkedListNode head;
    LinkedListNode tail;
    LinkedListNode current;
    public int Count { get; set; }
    public MyLinkedList()
    {
      head = null;
      tail = null;
      current = head;
    }
    public MyLinkedList(int value)
    {
      LinkedListNode node = new LinkedListNode(value);
      head = node;
      tail = node;
      current = new LinkedListNode();
      current.Next = head;
      Count++;

    }
    /// <summary>
    /// Adds new element with value.
    /// </summary>
    /// <param name="value">
    /// The value of added element.
    /// </param>
    public void Add(int value)
    {
      LinkedListNode node = new LinkedListNode(value);
      if (head == null)
        head = node;
      else
      {
        tail.Next = node;
        node.Previous = tail;
      }
      tail = node;
      Count++;
    }
    /// <summary>
    /// Adds and sets in first place new element with value.
    /// </summary>
    /// <param name="value">
    /// The value of added element.
    /// </param>
    public void AddFirst(int value)
    {
      LinkedListNode node = new LinkedListNode(value);
      LinkedListNode temp = head;
      node.Next = temp;
      head = node;
      if (Count == 0)
        tail = head;
      else
        temp.Previous = node;
      Count++;
    }
    /// <summary>
    /// Clear the list.
    /// </summary>
    public void Clear()
    {
      head = null;
      tail = null;
      Count = 0;
    }
    /// <summary>
    /// Tries to find value in list.
    /// </summary>
    /// <param name="value">
    /// Value to search.  
    /// </param>
    /// <returns>
    /// True if value were found,otherwise false. 
    /// </returns>
    public bool Contains(int value)
    {
      LinkedListNode current = head;
      while (current != null)
      {
        if (current.Value == value)
          return true;
        current = current.Next;
      }
      return false;
    }
    /// <summary>
    /// Removes first occurrence of value in list.
    /// </summary>
    /// <param name="value">
    /// Value to remove.
    /// </param>
    /// <returns>
    /// True if value were removed, otherwise false.
    /// </returns>
    public bool Remove(int value)
    {
      LinkedListNode currentNode = head;
      while (currentNode != null)
      {
        if (currentNode.Value == value)
        {
          break;
        }
        currentNode = currentNode.Next;
      }
      if (currentNode != null)
      {
        if (currentNode.Next != null)
        {
          currentNode.Next.Previous = currentNode.Previous;
        }
        else
        {
          tail = currentNode.Previous;
        }
        if (currentNode.Previous != null)
        {
          currentNode.Previous.Next = currentNode.Next;
        }
        else
        {
          head = currentNode.Next;
        }
        Count--;
        return true;
      }
      return false;
    }

    /// <summary>
    /// Gets first element.
    /// </summary>
    /// <returns>
    /// First element of list.
    /// </returns>
    public LinkedListNode GetHead()
    {
      return head;
    }
    /// <summary>
    /// Gets last element.
    /// </summary>
    /// <returns>
    /// Last element of list.
    /// </returns>
    public LinkedListNode GetTail()
    {
      return tail;
    }

    /// <summary>
    /// Get next element of list.
    /// </summary>
    /// <returns>
    /// Next element.
    /// </returns>
    public LinkedListNode GetNext()
    {
      if (current == null)
      {
        return null;
      }
      current = current.Next;
      return current;
    }

  }
}
