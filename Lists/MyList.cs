using System;

namespace LinkedLists
{
  /// <summary>
  /// Implementation of int list.
  /// </summary>
  public class MyList
  {
    ListNode head;
    ListNode tail;
    ListNode current;
    public int Count { get; set; }
    public MyList()
    {
      head = null;
      tail = null;
      current = head;
    }
    public MyList(int value)
    {
      ListNode node = new ListNode(value);
      head = node;
      tail = node;
      current = new ListNode();
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
      ListNode node = new ListNode(value);
      if (head == null)
      {
        head = node;
        tail = node;
        Count++;
      }
      else
      {
        tail.Next = node;
        tail = node;
        Count++;
      }
    }
    /// <summary>
    /// Adds and sets in first place new element with value.
    /// </summary>
    /// <param name="value">
    /// The value of added element.
    /// </param>
    public void AddFirst(int value)
    {
      ListNode node = new ListNode(value);
      node.Next = head;
      head = node;
      if (Count == 0)
        tail = head;
      Count++;
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
      ListNode node = head;
      if (head == null)
      {
        throw new Exception("Ur list is empty!");
      }
      while (node != tail)
      {
        if (node.Next.Value == value)
        {
          node.Next = node.Next.Next;
          Count--;
          return true;
        }
        node = node.Next;
      }
      return false;
    }
    /// <summary>
    /// Clear the list.
    /// </summary>
    public void Clear()
    {
      head = null;
      tail = null;
      current=null;
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
      ListNode current = head;
      while (current != null)
      {
        if (current.Value == value)
          return true;
        current = current.Next;
      }
      return false;
    }

    /// <summary>
    /// Gets first element.
    /// </summary>
    /// <returns>
    /// First element of list.
    /// </returns>
    public ListNode GetHead()
    {
      return head;
    }
    /// <summary>
    /// Gets last element.
    /// </summary>
    /// <returns>
    /// Last element of list.
    /// </returns>
    public ListNode GetTail()
    {
      return tail;
    }
    /// <summary>
    /// Get next element of list.
    /// </summary>
    /// <returns>
    /// Next element.
    /// </returns>

    public ListNode GetNext()
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
