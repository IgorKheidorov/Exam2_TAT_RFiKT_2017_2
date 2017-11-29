namespace Test_3.Task_4
{
  /// <summary>
  /// This class realizes singly linked list.
  /// </summary>
  public class SinglyLinkedList
  {
    private Node firstElement;
    private Node lastElement;
    private int count = 0;
    private Node current = new Node();

    /// <summary>
    /// This method adds element in the back of list.
    /// </summary>
    /// <param name="value">Element that will be added.</param>
    public void AddBack(int value)
    {
      Node node = new Node(value);

      if (firstElement == null)
      {
        firstElement = node;
        lastElement = node;
      }
      else
      {
        lastElement.Next = node;
        lastElement = node;
      }

      count++;
    }

    /// <summary>
    /// This method adds element in the front of list.
    /// </summary>
    /// <param name="value">Element that will be added.</param>
    public void AddFront(int value)
    {
      Node node = new Node(value);

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
    /// This method gets link on the next element.
    /// </summary>
    /// <returns>Retrns link on the next element.</returns>
    public Node GetNext()
    {
      Node result = new Node();
      if (current.Next != null)
      {
        result = current.Next;
      }
      current = current.Next;

      return result;
    }

    /// <summary>
    /// This method checks availability of elements in the list.
    /// </summary>
    /// <param name="value">Element that need to check.</param>
    /// <returns>Returns true if element is contained, and false if not.<</returns>
    public bool Contains(int value)
    {
      current = firstElement;
      while (current.Next != null)
      {
        if (current.Value != value)
        {
          current = current.Next;
        }
        else
        {
          return true;
        }
      }

      if (lastElement.Value == value)
      {
        return true;
      }

      return false;
    }

    /// <summary>
    /// Assigns the first element to the current one.
    /// </summary>
    public void AssignFirstToCurrent()
    {
      current = firstElement;
    }

    public int Count { get { return count; } }
  }
}
