using System;

namespace LinkedLists
{
  /// <summary>
  /// The point where program starts.
  /// </summary>
  class Program
  {
    static void Main(string[] args)
    {
      MyLinkedList list = new MyLinkedList(5);
      list.Add(10);
      list.Add(15);
      list.Add(20);
      LinkedListNode element;
      while ((element = list.GetNext()) != null)
      {
        Console.Write(element.Value);
      }
    }

  }
}
