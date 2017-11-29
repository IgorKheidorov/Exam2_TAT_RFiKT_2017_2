using System;
using System.Collections.Generic;

namespace UnidirectionalListBidirectionalList
{
  /// <summary>
  /// This class of Unidirectional List
  /// </summary>
  /// <typeparam name="T"> type of information in class</typeparam>
  public class UnidirectionalList<T>
  {
    Node<T> firstElement;
    Node<T> finalElement;
    public int Count { get; set; }

    /// <summary>
    /// This methode return information of list by index
    /// </summary>
    /// <param name="index">of interested us element of list</param>
    /// <returns>information of index of this list</returns>
    public T GetData(int index)
    {
      Node<T> current = firstElement;
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
    /// This method add new element in unidirectional list
    /// </summary>
    /// <param name="information"> infromation which we want add</param>
    public void AddElement(T information)
    {
      Node<T> node = new Node<T>(information);
      if (firstElement == null)
        firstElement = node;
      else
        finalElement.Next = node;
      finalElement = node;
      Count = Count + 1;
    }
    
    /// <summary>
    /// This methode remove elem with param information
    /// </summary>
    /// <param name="information">which we need remove</param>
    /// <returns>true if remove element
    /// false if can't remove element</returns>
    public bool Remove(T information)
    {
      Node<T> actual = firstElement;
      Node<T> previous = null;
      while (actual != null)
      {
        if (actual.Data.Equals(information))
        {
          if (previous != null)
          {
            previous.Next = actual.Next;
            if (actual.Next == null)
              finalElement = previous;
          }
          else
          {
            firstElement = firstElement.Next;
            if (firstElement == null)
              finalElement = null;
          }
          Count = Count - 1;
          return true;
        }
        previous = actual;
        actual = actual.Next;
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
    public bool Contains(T information)
    {
      Node<T> actual = firstElement;
      while (actual != null)
      {
        if (actual.Data.Equals(information))
          return true;
        actual = actual.Next;
      }
      return false;
    }

    /// <summary>
    /// Add element on start of list 
    /// </summary>
    /// <param name="information">what we want add</param>
    public void AddFirstElement(T information)
    {
      Node<T> node = new Node<T>(information);
      node.Next = firstElement;
      firstElement = node;
      if (Count == 0)
        finalElement = firstElement;
      Count = Count + 1;
    }
  }
}