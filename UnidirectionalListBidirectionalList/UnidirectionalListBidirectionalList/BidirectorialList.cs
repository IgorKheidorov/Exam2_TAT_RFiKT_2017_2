namespace UnidirectionalListBidirectionalList
{
  public class BidirectorialList<T>
  {
    DoublyNode<T> firstElement;
    DoublyNode<T> finalElement;
    public int Count { get; set; }

    /// <summary>
    /// This method add new element in unidirectional list
    /// </summary>
    /// <param name="information"> infromation which we want add</param>
    public void AddElement(T information)
    {
      DoublyNode<T> node = new DoublyNode<T>(information);

      if (firstElement == null)
        firstElement = node;
      else
      {
        finalElement.Next = node;
        node.Previous = finalElement;
      }
      finalElement = node;
      Count = Count + 1; 
    }

    /// <summary>
    /// Add element on start of list 
    /// </summary>
    /// <param name="information">what we want add</param>
    public void AddOnFirstElement(T information)
    {
      DoublyNode<T> node = new DoublyNode<T>(information);
      DoublyNode<T> temp = firstElement;
      node.Next = temp;
      firstElement = node;
      if (Count == 0)
        finalElement = firstElement;
      else
        temp.Previous = node;
      Count = Count + 1;
    }

    /// <summary>
    /// This methode return information of list by index
    /// </summary>
    /// <param name="index">of interested us element of list</param>
    /// <returns>information of index of this list</returns>
    public T GetData(int index)
    {
      DoublyNode<T> current = firstElement;
      int counter = 0;
      while (current != null)
      {
        if (counter == index)
          return current.Data;
        current = current.Next;
        counter = counter + 1;
      }
      return current.Data;
    }

    /// <summary>
    /// This methode remove elem with param information
    /// </summary>
    /// <param name="information">which we need remove</param>
    /// <returns>true if remove element
    /// false if can't remove element</returns>
    public bool Remove(T information)
    {
      DoublyNode<T> current = firstElement;
      while (current != null)
      {
        if (current.Data.Equals(information))
        {
          break;
        }
        current = current.Next;
      }
      if (current != null)
      {
        if (current.Next != null)
        {
          current.Next.Previous = current.Previous;
        }
        else
        {
          finalElement = current.Previous;
        }
        if (current.Previous != null)
        {
          current.Previous.Next = current.Next;
        }
        else
        {
          firstElement = current.Next;
        }
        Count = Count - 1;
        return true;
      }
      return false;
    }

    /// <summary>
    /// Check list on empty 
    /// </summary>
    /// <returns>true if empty
    /// false if not empty</returns>
    public bool IsEmpty()
    {
      return Count == 0;
    }

    /// <summary>
    /// This methode clear all list
    /// </summary>
    public void Clear()
    {
      firstElement = null;
      finalElement = null;
      Count = 0;
    }

    /// <summary>
    /// This methode check list on needed element
    /// </summary>
    /// <param name="information"></param>
    /// <returns>true if find
    /// false if not found</returns>
    public bool Contains(T data)
    {
      DoublyNode<T> current = firstElement;
      while (current != null)
      {
        if (current.Data.Equals(data))
          return true;
        current = current.Next;
      }
      return false;
    }
  }
}
